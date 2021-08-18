using AddressBook.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Windows.Settings.Database
{
    public partial class FormSettingsDatabase : Form
    {
        DBConnection connDB;
        public FormSettingsDatabase(DBConnection connDB)
        {
            InitializeComponent();
            ResetInputBoxes();
            this.connDB = connDB;
        }

        private bool ValidateData()
        {
            if(string.IsNullOrEmpty(textBoxServer.Text) ||
                string.IsNullOrEmpty(textBoxDatabase.Text) ||
                string.IsNullOrEmpty(textBoxUser.Text) ||
                string.IsNullOrEmpty(textBoxPassword.Text) ||
                string.IsNullOrEmpty(numericUpDownPort.Value.ToString()) ||
                textBoxServer.Text.Length > 16 ||
                textBoxUser.Text.Length > 32 ||
                textBoxPassword.Text.Length > 32
                )
                return false;
            return true;
        }

        private DBConnection copyData()
        {
            string server = textBoxServer.Text;
            if(textBoxServer.Text != "localhost")
                server += numericUpDownPort.Value.ToString();
            return new DBConnection(
                    server,
                    textBoxDatabase.Text,
                    textBoxUser.Text,
                    textBoxPassword.Text
                    );
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DBConnection ConnDB
        {
            get
            {
                return connDB;
            }
        }

        private void ResetInputBoxes()
        {
            textBoxServer.Text = "localhost";
            textBoxDatabase.Text = "database";
            textBoxUser.Text = "username";
            textBoxPassword.Text = "";
            numericUpDownPort.Value = 3306;
            panel1.Refresh();
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                connDB = copyData();
            }
        }

        private void buttonResetToDefault_Click(object sender, EventArgs e)
        {
            ResetInputBoxes();
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            DBConnection connDBTest = copyData();
            if (connDBTest.TestConnection())
            {
                MessageBox.Show("Connection successful!", "Connection Test");
            }
            else
            {
                MessageBox.Show("Connection failed!", "Connection Test");
            }
        }
    }
}
