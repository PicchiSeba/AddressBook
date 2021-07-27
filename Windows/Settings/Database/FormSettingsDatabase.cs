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
            this.connDB = connDB;
        }

        private bool ValidateData()
        {
            throw new NotImplementedException();
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

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                connDB = copyData();
            }
        }

        private void buttonResetToDefault_Click(object sender, EventArgs e)
        {
            textBoxServer.Text = "";
            textBoxDatabase.Text = "";
            textBoxUser.Text = "";
            textBoxPassword.Text = "";
            numericUpDownPort.Value = 3306;
            panel1.Refresh();
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
