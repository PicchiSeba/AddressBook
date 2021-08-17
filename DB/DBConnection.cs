using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AddressBook.Model;
using AddressBook.Models;
using AddressBook.Models.BaseClasses;
using System.Globalization;

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
            database = "app_db_01";
            uid = "root";
            password = "root";

            connection = new MySqlConnection(
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";"
                );
        }

        public DBConnection(
            string server,
            string database,
            string uid,
            string password
            )
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.password = password;

            connection = new MySqlConnection(
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";"
                );
        }

        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }
        }

        /// <summary>
        /// Pretty self-explanatory: opens a connection to the MySql Server using the credential set in the constructor
        /// </summary>
        public bool OpenConnection()
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
                    default:
                        MessageBox.Show("Un-catched error: please see through debug mode");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Like above: but closes the connection instead
        /// </summary>
        public bool CloseConnection()
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

        public bool TestConnection()
        {
            if (this.OpenConnection())
            {
                this.CloseConnection();
                return true;
            }
            return false;
        }
    }
}
