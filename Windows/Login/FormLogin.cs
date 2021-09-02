using AddressBook.DB;
using AddressBook.Models;
using AddressBook.Models.BaseClasses;
using AddressBook.Windows.Main;
using AddressBook.Windows.Settings.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Windows.Login
{
    public partial class FormLogin : Form
    {
        DBConnection connDB = new DBConnection();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            IUser foundUser = new BaseUser();
            foreach(IUser singleUser in new BaseUser().SelectAllUsers(connDB))
            {
                if (singleUser.Username == textBoxUsername.Text)
                {
                    foundUser = singleUser;
                    break;
                }
            }

            if (foundUser.Password == this.CreateMD5(textBoxPassword.Text))
            {
                this.Hide();
                FormMain mainWindow = new FormMain(foundUser.Admin, connDB);
                mainWindow.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid combination username/password");
            }
        }

        /// <summary>
        /// copied from https://stackoverflow.com/a/24031467
        /// on the 2nd sept '21
        /// </summary>
        /// <param name="input">string to be converted to MD5</param>
        /// <returns></returns>
        private string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<IUser> SelectAllUsers()
        {
            return new BaseUser().SelectAllUsers(connDB);
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            FormSettingsDatabase formSettingsDatabase = new FormSettingsDatabase(connDB);
            formSettingsDatabase.ShowDialog();
            connDB = formSettingsDatabase.ConnDB;
        }
    }
}

