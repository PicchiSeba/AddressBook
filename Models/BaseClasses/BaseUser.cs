using AddressBook.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models.BaseClasses
{
    public class BaseUser : IUser
    {
        private int id;
        private string username;
        private bool admin;
        private string password;

        public BaseUser()
        {
        }
        public BaseUser(string username, string password, bool admin)
        {
            this.username = username;
            this.password = password;
            this.admin = admin;
        }
        public BaseUser(int id, string username, bool admin)
        {
            this.id = id;
            this.username = username;
            this.admin = admin;
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

        public List<IUser> SelectAllUsernames(DBConnection connDB)
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
                        new BaseUser(
                            Convert.ToInt32(dataReader["ID"].ToString()),
                            dataReader["username"].ToString(),
                            Convert.ToBoolean(dataReader["admin"])
                            )
                        );
                }
                connDB.CloseConnection();
            }
            return allQueries;
        }

        public bool CheckPassword(IUser user, string password, DBConnection connDB)
        {
            if (connDB.OpenConnection())
            {
                string query = "SELECT * FROM users WHERE id_user=" + user.ID;
            }
            return false;
        }

        public void DeleteUser(DBConnection connDB, int id)
        {
            throw new NotImplementedException();
        }

        public void InsertUser(DBConnection connDB)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(DBConnection connDB, IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
