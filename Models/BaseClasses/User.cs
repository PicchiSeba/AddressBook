using AddressBook.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models.BaseClasses
{
    public class User : IUser
    {
        private int id;
        private string username;
        private bool admin;
        private string password;

        public User()
        {

        }

        public User(int id, string username, bool admin, string password)
        {
            this.id = id;
            this.username = username;
            this.admin = admin;
            this.password = password;
        }

        public int ID
        {
            get
            {
                return id;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
        }

        public bool Admin
        {
            get
            {
                return admin;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }

        public List<IUser> SelectAllUsers(DBConnection connDB)
        {
            string query = "SELECT * FROM users";
            List<IUser> allQueries = new List<IUser>();
            if (connDB.OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connDB.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    allQueries.Add(
                        new User(
                            int.Parse(dataReader["id_user"].ToString()),
                            dataReader["username"].ToString(),
                            Convert.ToBoolean(dataReader["role"].ToString()),
                            dataReader["password"].ToString()
                            )
                        );
                }
                connDB.CloseConnection();
            }
            return allQueries;
        }

        public void DeleteUser(DBConnection connDB, int id)
        {
            throw new NotImplementedException();
        }

        public void InsertUser(DBConnection connDB, IUser user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(DBConnection connDB, IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
