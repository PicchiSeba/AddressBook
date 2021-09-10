using AddressBook.DB;
using AddressBook.Models;
using AddressBook.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Windows.Database.Users
{
    public partial class FormUsers : Form
    {
        DBConnection connDB;
        List<IUser> allUsers;

        public FormUsers(DBConnection connDB)
        {
            InitializeComponent();
            this.connDB = connDB;
            this.LoadUsernames();
        }

        private void LoadUsernames()
        {
            allUsers = new BaseUser().SelectAllUsernames(connDB);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxUsername.Text) ||
                string.IsNullOrEmpty(textBoxPassword.Text) ||
                string.IsNullOrEmpty(textBoxPassConfirm.Text) ||
                textBoxPassword.Text != textBoxPassConfirm.Text
                )
            {
                MessageBox.Show("Missing key data, control textboxes before submitting an Insert request");
            }
            else
            {
                bool exists = false;
                foreach (IUser singleUser in allUsers)
                {
                    if(singleUser.Username == textBoxUsername.Text)
                    {
                        exists = true;
                        break;
                    }
                }
                if (exists)
                {
                    MessageBox.Show("Username already exists, choose another username or abort operation");
                }
                else
                {
                    new BaseUser(
                        textBoxUsername.Text,
                        textBoxPassword.Text,
                        checkBoxAdmin.Checked
                        ).InsertUser(connDB);
                    MessageBox.Show("User successfully added to the database");
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
