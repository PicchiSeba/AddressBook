using AddressBook.DB;
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
            if (true)
            {
                this.Hide();
                FormMain mainWindow = new FormMain(true, connDB);
                mainWindow.ShowDialog();
                this.Show();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectAllUsers()
        {

        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            FormSettingsDatabase formSettingsDatabase = new FormSettingsDatabase(connDB);
            formSettingsDatabase.ShowDialog();
            connDB = formSettingsDatabase.ConnDB;
        }
    }
}

