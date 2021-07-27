using AddressBook.DB;
using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Windows.Payments
{
    public partial class FormAddSinglePayment : Form
    {
        private DBConnection connDB;
        private List<IContact> users;

        public FormAddSinglePayment(DBConnection connDB)
        {
            this.connDB = connDB;
            InitializeComponent();
            LoadUsers();
            comboBoxUser.Refresh();
        }

        private void LoadUsers()
        {
            users = connDB.SelectAllContacts();
            foreach (IContact singleUser in users)
            {
                comboBoxUser.Items.Add(singleUser.ToString());
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(richTextBoxDescription.Text) ||
                richTextBoxDescription.Text.Length > 1024
                ) return false;
            foreach(char singleChar in textBoxDebt.Text)
            {
                if ( ! (char.IsDigit(singleChar) ||
                    singleChar.Equals("."))
                    ) return false;
            }
            foreach (char singleChar in textBoxProfit.Text)
            {
                if (!(char.IsDigit(singleChar) ||
                    singleChar.Equals("."))
                    ) return false;
            }
            return true;
        }

        private void buttonReturn_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                float debt, profit;
                if (string.IsNullOrEmpty(textBoxDebt.Text)) debt = 0;
                else debt = Convert.ToSingle(textBoxDebt.Text);
                if (string.IsNullOrEmpty(textBoxProfit.Text)) profit = 0;
                else profit = Convert.ToSingle(textBoxProfit.Text);
                connDB.InsertNote(
                    new BaseNote(
                        users[comboBoxUser.SelectedIndex],
                        richTextBoxDescription.Text,
                        debt,
                        profit
                        )
                    );
                MessageBox.Show("Note successfully added to the database", "Addition success");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxUser.SelectedIndex = -1;
            richTextBoxDescription.Clear();
            textBoxDebt.Clear();
            textBoxProfit.Clear();
            panelActions.Refresh();
        }
    }
}
