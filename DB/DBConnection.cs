using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AddressBook.Model;

namespace AddressBook.DB
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        /// <summary>
        /// Database connection creation
        /// These lines are based on my current MySql configuration
        /// I plan to make this editable in some way
        /// </summary>
        public DBConnection()
        {
            server = "localhost";
            database = "addressBook";
            uid = "root";
            password = "root";

            connection = new MySqlConnection(
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";"
                );
        }

        /// <summary>
        /// Pretty self-explanatory: opens a connection to the MySql Server using the credential set in the constructor
        /// </summary>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Database error 0: Cannot connect to server.");
                        break;

                    case 1045:
                        MessageBox.Show("Database error 1045: Invalid username/password combination");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Like above: but closes the connection instead
        /// </summary>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List < IContact > SelectAllContacts()
        {
            List<IAddress> allAddresses = SelectAllAddresses();


            string query = "SELECT * FROM contacts";
            List<IContact> allQueries = new List<IContact>();

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    allQueries.Add(
                        new BaseContact(
                            int.Parse(dataReader["ID"].ToString()),
                            dataReader["name"].ToString(),
                            new BaseAddress(int.Parse(dataReader["address"].ToString())),
                            dataReader["phoneNumber"].ToString()
                            )
                        );
                }

                this.CloseConnection();
            }

            for(int i = 0; i < allQueries.Count; i++)
            {
                for(int j = 0; j < allAddresses.Count; j++)
                {
                    if(allQueries[i].Address.ID == allAddresses[j].ID)
                    {
                        allQueries[i].SubstituteAddress(allAddresses[j]);
                        break;
                    }
                }
            }

            return allQueries;
        }

        public void InsertContact(string name, int addressID, string phoneNumber)
        {
            string query = "";
                
            query = "INSERT INTO contacts (name, address, phoneNumber) " +
                "VALUES('" + name + "', '" + addressID + "', '" + phoneNumber + "')";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void DeleteContact(int id)
        {
            string query = "SELECT * FROM contacts WHERE ID=" + id.ToString();
            int addressID = 0;


            // finding the contact's address id
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    addressID = int.Parse(
                            dataReader["address"].ToString()
                    );
                }
                this.CloseConnection();
            }
            
            // 
            query = "DELETE FROM contacts WHERE ID=" + id.ToString() + ";";
            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }


            // if there is no entry then i can delete it
            query = "SELECT * FROM contacts WHERE address=" + addressID + ";";
            if (this.OpenConnection())
            {
                int addressUsedBy = 0;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                // counting
                while (dataReader.Read())
                {
                    addressUsedBy++;
                }
                this.CloseConnection();
                // deletion only if there is no address entry among all the contacts
                if (addressUsedBy == 0)
                {
                    DeleteAddress(addressID);
                }
            }
        }

        public void UpdateContact(int id, string name, int address, string phoneNumber)
        {
            string query = "UPDATE contacts " +
                "SET name='" + name + "' " +
                ", address='" + address + "' " +
                ", phoneNumber='" + phoneNumber + "' " +
                "WHERE ID=" + id + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<IContact> SearchKeywordContact(string keyword)
        {
            List<IContact> matches = new List<IContact>();

            string query = "SELECT * FROM contacts WHERE name='" + keyword + "';";
            findElemContact(query, matches);
            
            query = "SELECT * FROM contacts WHERE address='" + keyword + "';";
            findElemContact(query, matches);
            
            query = "SELECT * FROM contacts WHERE phoneNumber='" + keyword + "';";
            findElemContact(query, matches);



            return matches;
        }

        private void findElemContact(string query, List<IContact> matches)
        {

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    bool found = false;
                    foreach (IContact singleEntry in matches)
                    {
                        if (singleEntry.ID.ToString() == dataReader["ID"].ToString())
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        matches.Add(
                        new BaseContact(
                            int.Parse(dataReader["ID"].ToString()),
                            dataReader["name"].ToString(),
                            new BaseAddress(int.Parse(dataReader["address"].ToString())),
                            dataReader["phoneNumber"].ToString()
                            )
                        );
                    }
                }

                this.CloseConnection();
            }
        }

        public IContact GetContactByID(int id)
        {
            List < IContact > toReturn = new List<IContact>();
            toReturn.Add(new BaseContact());

            string query = "SELECT * FROM contacts WHERE ID=" + id + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    toReturn[0] = new BaseContact(
                        int.Parse(dataReader["ID"].ToString()),
                        dataReader["name"].ToString(),
                        new BaseAddress(int.Parse(dataReader["address"].ToString())),
                        dataReader["phoneNumber"].ToString()
                        );
                }
                this.CloseConnection();
            }

            return toReturn[0];
        }

        public List < IAddress > SelectAllAddresses()
        {
            string query = "SELECT * FROM addresses";
            List<IAddress> allQueries = new List<IAddress>();

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    allQueries.Add(
                        new BaseAddress(
                            int.Parse(dataReader["id"].ToString()),
                            dataReader["street"].ToString(),
                            dataReader["number"].ToString(),
                            dataReader["postalCode"].ToString(),
                            dataReader["municipality"].ToString(),
                            dataReader["province"].ToString(),
                            dataReader["country"].ToString()
                            )
                        );
                }

                this.CloseConnection();
            }

            return allQueries;
        }

        public void InsertAddress(IAddress address)
        {
            string query = "INSERT INTO addresses (street, number, postalCode, municipality, province, country) " +
                "VALUES('" + address.Street + "', '" +
                address.Number + "', '" +
                address.PostalCode + "', '" +
                address.Municipality + "', '" +
                address.Province + "', '" +
                address.Country + "')";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void DeleteAddress(int id)
        {
            string query = "DELETE FROM addresses WHERE id=" + id.ToString() + ";";

            if (this.OpenConnection() && id != 0)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateAddress(IAddress address)
        {
            string query = "UPDATE addresses " +
                "SET street='" + address.Street + "' " +
                ", number='" + address.Number + "' " +
                ", postalCode='" + address.PostalCode + "' " +
                ", municipality='" + address.Municipality + "' " +
                ", province='" + address.Province + "' " +
                ", country='" + address.Country + "' " +
                "WHERE ID=" + address.ID + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List < INote > SelectPaymentsByUserID(int id_user) {
            List<INote> allQueries = new List<INote>();
            string query = "SELECT * FROM notes WHERE id_user=" + id_user + ";";

            List<IContact> allContacts = SelectAllContacts();

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    IContact user = new BaseContact();
                    foreach(IContact singleContact in allContacts)
                    {
                        if (singleContact.ID == Convert.ToInt32(dataReader["id_user"].ToString()))
                        {
                            allQueries.Add(
                                new BaseNote(
                                    int.Parse(dataReader["id_note"].ToString()),
                                    singleContact,
                                    dataReader["description"].ToString(),
                                    Convert.ToSingle(dataReader["amountDebt"].ToString()),
                                    Convert.ToSingle(dataReader["amountProfit"].ToString())
                                    )
                            );
                            break;
                        }
                    }
                }

                this.CloseConnection();
            }

            return allQueries;
        }

        public void InsertNote(INote note)
        {
            string query = "INSERT INTO notes (id_user, description, amountDebt, amountProfit) " +
                "VALUES(" +
                note.User.ID + ", " +
                "'" + note.Description + "', " +
                note.Debt + ", " +
                note.Profit + ")"
                + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void DeleteNote(int id)
        {
            string query = "DELETE FROM notes WHERE id_note=" + id.ToString() + ";";

            if (this.OpenConnection() && id != 0)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void UpdateNote(INote note)
        {
            string query = "UPDATE notes " +
                "SET id_user=" + note.User.ID + 
                ", description='" + note.Description +
                "', amountDebt=" + note.Debt +
                ", amountProfit=" + note.Profit +
                " WHERE id_note=" + note.ID + ";";

            if (this.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}
