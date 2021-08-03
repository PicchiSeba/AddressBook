using AddressBook.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public class BaseContact : IContact
    {
        private int id;
        private string name;
        private IAddress address;
        private string phoneNumber;

        public BaseContact()
        {
        }

        public BaseContact(int id, string name, IAddress address, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public int ID
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        public IAddress Address
        {
            get
            {
                return address;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
        }

        public void SubstituteAddress(IAddress toCopyFrom)
        {
            this.address = toCopyFrom;
        }

        public override string ToString()
        {
            return "[" + id + "] " +
                name + ", " +
                address.ToString() + ", " +
                phoneNumber;
        }

        /// <summary>
        /// Selects all entries from 'contacts' table
        /// </summary>
        /// <returns>List of BaseContact objects</returns>
        public List<IContact> SelectAllContacts(DBConnection connDB)
        {
            List<IAddress> allAddresses = new BaseAddress().SelectAllAddresses(connDB);
            string query = "SELECT * FROM contacts";
            List<IContact> allQueries = new List<IContact>();

            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    allQueries.Add(
                        new BaseContact(
                            int.Parse(dataReader["id_contact"].ToString()),
                            dataReader["name"].ToString(),
                            new BaseAddress(int.Parse(dataReader["id_address"].ToString())),
                            dataReader["phone_number"].ToString()
                            )
                        );
                }
                connDB.CloseConnection();
            }

            for (int i = 0; i < allQueries.Count; i++)
            {
                for (int j = 0; j < allAddresses.Count; j++)
                {
                    if (allQueries[i].Address.ID == allAddresses[j].ID)
                    {
                        allQueries[i].SubstituteAddress(allAddresses[j]);
                        break;
                    }
                }
            }

            return allQueries;
        }

        /// <summary>
        /// Inserts a new element in 'contacts' table
        /// </summary>
        /// <param name="name">name in the database, string, no more than 128 characters</param>
        /// <param name="addressID">id_address in the database, Integer</param>
        /// <param name="phoneNumber">phoneNumber in the database, string, max 16 characters</param>
        public void InsertContact(DBConnection connDB, IContact contact)
        {
            string query = "INSERT INTO contacts (name, id_address, phone_number) " +
                "VALUES('" + contact.Name + "', '" + contact.Address + "', '" + contact.PhoneNumber + "')";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Remove an entry from 'contacts' table. If the address isn't used anymore removes that too
        /// </summary>
        /// <param name="id">id_contact in the database</param>
        public void DeleteContact(DBConnection connDB, int id)
        {
            string query = "SELECT * FROM contacts WHERE id_contact=" + id.ToString();
            int addressID = 0;

            // finding the contact's address id
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    addressID = int.Parse(
                            dataReader["id_address"].ToString()
                    );
                }
                connDB.CloseConnection();
            }
            // 
            query = "DELETE FROM contacts WHERE id_contact=" + id.ToString() + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Updates an entry in the 'contacts' table
        /// </summary>
        /// <param name="id">id_contact in the database</param>
        /// <param name="name">name in the database, string, max 16 characters</param>
        /// <param name="address">id_address in the database, int</param>
        /// <param name="phoneNumber">phoneNumber in the database, string, max 16 characters</param>
        public void UpdateContact(DBConnection connDB, IContact contact)
        {
            string query = "UPDATE contacts " +
                "SET name='" + contact.Name + "' " +
                ", id_address='" + contact.Address + "' " +
                ", phone_number='" + contact.PhoneNumber + "' " +
                "WHERE id_contact=" + contact.ID + ";";

            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Search fuction in the 'Contact' window
        /// </summary>
        /// <param name="keyword">keyword to research</param>
        /// <returns>returns a List of 'BaseContact's entries that have that keyword somewhere</returns>
        public List<IContact> SearchKeywordContact(DBConnection connDB, string keyword)
        {
            List<IContact> matches = new List<IContact>();

            string query = "SELECT * FROM contacts WHERE name='" + keyword + "';";
            findElemContact(connDB, query, matches);

            query = "SELECT * FROM contacts WHERE phone_number='" + keyword + "';";
            findElemContact(connDB, query, matches);

            /*query = "SELECT * FROM contacts WHERE id_address='" + keyword + "';";
            findElemContact(query, matches);*/

            return matches;
        }

        /// <summary>
        /// A List is passed and if the element sepecified in the query is found, it is added to the List
        /// </summary>
        /// <param name="query">database query, pretty self-explanatory</param>
        /// <param name="matches">List of all findings</param>
        private void findElemContact(DBConnection connDB, string query, List<IContact> matches)
        {
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    bool found = false;
                    foreach (IContact singleEntry in matches)
                    {
                        if (singleEntry.ID.ToString() == dataReader["id_contact"].ToString())
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        matches.Add(
                        new BaseContact(
                            int.Parse(dataReader["id_contact"].ToString()),
                            dataReader["name"].ToString(),
                            new BaseAddress(int.Parse(dataReader["id_address"].ToString())),
                            dataReader["phone_number"].ToString()
                            )
                        );
                    }
                }
                connDB.CloseConnection();
            }
            for (int index = 0; index < matches.Count; index++)
            {
                string secondQuery = "SELECT * FROM addresses WHERE id_address=" + matches[index].Address.ID + ";";
                if (connDB.OpenConnection())
                {
                    MySqlCommand command = new MySqlCommand(secondQuery, connDB.Connection);
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        matches[index].SubstituteAddress(
                            new BaseAddress(
                                int.Parse(dataReader["id_address"].ToString()),
                                dataReader["street"].ToString(),
                                dataReader["number"].ToString(),
                                dataReader["postal_code"].ToString(),
                                dataReader["municipality"].ToString(),
                                dataReader["province"].ToString(),
                                dataReader["country"].ToString()
                                )
                            );
                    }
                    connDB.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Searches a single entry with the given ID in the 'contacts' table, if found returns the data as an object
        /// </summary>
        /// <param name="id">The ID to find</param>
        /// <returns>'BaseContact' object containing the contact's data, or an empty object if none was found</returns>
        public IContact GetContactByID(DBConnection connDB, int id)
        {
            List<IContact> toReturn = new List<IContact>();
            toReturn.Add(new BaseContact());
            string query = "SELECT * FROM contacts WHERE id_contact=" + id + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    toReturn[0] = new BaseContact(
                        int.Parse(dataReader["ID"].ToString()),
                        dataReader["name"].ToString(),
                        new BaseAddress(int.Parse(dataReader["id_address"].ToString())),
                        dataReader["phone_number"].ToString()
                        );
                }
                connDB.CloseConnection();
            }
            return toReturn[0];
        }
    }
}
