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

        public FormAddSinglePayment()
        {
            connDB = new DBConnection();
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

        private bool ValidateData(string description, float debt, float profit)
        {
            if (string.IsNullOrEmpty(description) || description.Length > 1024) return false;

            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (
                ValidateData(
                    richTextBoxDescription.Text,
                    Convert.ToSingle(textBoxDebt.Text),
                    Convert.ToSingle(textBoxProfit.Text)
                    )
                )
            {
                connDB.InsertNote(
                    new BaseNote(
                        users[comboBoxUser.SelectedIndex],
                        richTextBoxDescription.Text,
                        Convert.ToSingle(textBoxDebt.Text),
                        Convert.ToSingle(textBoxProfit.Text)
                        )
                    );
            }
        }
    }
}
