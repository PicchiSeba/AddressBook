using AddressBook.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public class BaseNote : INote
    {
        private int id;
        private IContact user;
        private string description;
        private float debt;
        private float profit;

        public BaseNote() { }

        public BaseNote(
            IContact user,
            string description,
            float debt,
            float profit
            )
        {
            this.user = user;
            this.description = description;
            this.debt = debt;
            this.profit = profit;
        }

        public BaseNote(
            int id,
            IContact user,
            string description,
            float debt,
            float profit
            ) : this(user,
                description,
                debt,
                profit
                )
        {
            this.id = id;
        }

        public int ID
        {
            get
            {
                return id;
            }
        }

        public IContact User
        {
            get
            {
                return user;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public float Debt
        {
            get
            {
                return debt;
            }
        }

        public float Profit
        {
            get
            {
                return profit;
            }
        }

        /// <summary>
        /// Selects all payments done by a specific user in the 'notes' table
        /// </summary>
        /// <param name="id_user">user's id to search</param>
        /// <returns>List of BaseContacts objects with all the data found</returns>
        public List<INote> SelectPaymentsByUserID(DBConnection connDB, int id_user)
        {
            List<INote> allQueries = new List<INote>();
            string query = "SELECT * FROM notes WHERE id_user=" + id_user + ";";
            List<IContact> allContacts = new BaseContact().SelectAllContacts(connDB);

            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    IContact user = new BaseContact();
                    foreach (IContact singleContact in allContacts)
                    {
                        if (singleContact.ID == Convert.ToInt32(dataReader["id_user"].ToString()))
                        {
                            allQueries.Add(
                                new BaseNote(
                                    int.Parse(dataReader["id_note"].ToString()),
                                    singleContact,
                                    dataReader["description"].ToString(),
                                    Convert.ToSingle(dataReader["amount_debt"].ToString()),
                                    Convert.ToSingle(dataReader["amount_profit"].ToString())
                                    )
                            );
                            break;
                        }
                    }
                }
                connDB.CloseConnection();
            }
            return allQueries;
        }

        /// <summary>
        /// Inserts a new entry in the 'notes' table
        /// </summary>
        /// <param name="note">BaseNote object from which the data to add is fetched</param>
        public void InsertNote(DBConnection connDB, INote note)
        {
            string query = "INSERT INTO notes (id_user, description, amount_debt, amount_profit) " +
                "VALUES(" +
                note.User.ID + ", '" +
                note.Description + "', " +
                note.Debt + ", " +
                note.Profit + ");";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Deletes the entry in 'notes' table that has the ID given in input
        /// </summary>
        /// <param name="id">id_note in the database</param>
        public void DeleteNote(DBConnection connDB, int id)
        {
            string query = "DELETE FROM notes WHERE id_note=" + id.ToString() + ";";
            if (connDB.OpenConnection() && id != 0)
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }

        /// <summary>
        /// Updates an entry in the 'notes' table
        /// </summary>
        /// <param name="address">object from which the data to update is fetched</param>
        public void UpdateNote(DBConnection connDB, INote note)
        {
            string query = "UPDATE notes " +
                "SET id_user=" + note.User.ID +
                ", description='" + note.Description +
                "', amount_debt=" + note.Debt +
                ", amount_profit=" + note.Profit +
                " WHERE id_note=" + note.ID + ";";
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                command.ExecuteNonQuery();
                connDB.CloseConnection();
            }
        }
    }
}
