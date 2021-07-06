using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook.DB;
using AddressBook.Model;
using AddressBook.Windows.Address;
using AddressBook.Windows.DeleteConfirmation;
using AddressBook.Windows.Errors;

namespace AddressBook
{
    public partial class FormMain : Form
    {
        DBConnection connDB;
        private List<IAddress> allAddresses;

        public FormMain()
        {
            connDB = new DBConnection();
            InitializeComponent();
            LoadAllQueries();
            LoadAddresses();
        }

        private void LoadAllQueries()
        {
            listViewMain.Items.Clear();

            List<IContact> allContacts = connDB.SelectAllContacts();

            foreach(IContact contact in allContacts)
            {
                ListViewItem item = new ListViewItem(contact.ID.ToString());
                item.SubItems.Add(contact.Name);
                item.SubItems.Add(contact.Address.ToString());
                item.SubItems.Add(contact.PhoneNumber);
                listViewMain.Items.Add(item);
            }

            listViewMain.Refresh();
        }

        private void LoadAddresses()
        {
            comboBoxAddresses.Items.Clear();
            allAddresses = connDB.SelectAllAddresses();

            foreach(IAddress singleAddress in allAddresses)
            {
                string outputInTheList = "[" + singleAddress.ID + "] " +
                    singleAddress.Street + " " + singleAddress.Number + ", " +
                    singleAddress.PostalCode;
                comboBoxAddresses.Items.Add(outputInTheList);
            }

            comboBoxAddresses.Refresh();
        }

        // The string structure is supposed to be "[ID]other_things"
        private int FetchAddressIDFromString(string extractFrom)
        {
            string temp = "";
            int ind = 1;
            while (true)
            {
                if (char.IsDigit(extractFrom[ind])) temp += extractFrom[ind];
                else break;
                ind++;
            }

            return int.Parse(temp);
        }

        private void ClearTextBoxes()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            comboBoxAddresses.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxSearch.Text = "";

            groupBoxActions.Refresh();
        }

        private bool ValidateData(string name, string address, string phoneNumber)
        {
            if (name.Length > 128) return false;

            foreach(char singleChar in phoneNumber)
            {
                bool isANumber = false;
                for(int i = 0; i < 10; i++)
                {
                    if (singleChar.ToString().Equals(i.ToString())) isANumber = true;
                }
                if (!isANumber) return false;
            }

            return true;
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(comboBoxAddresses.Text) ||
                string.IsNullOrEmpty(textBoxPhoneNumber.Text)
                )
            {

            }
            else
            {
                if (ValidateData(textBoxName.Text, comboBoxAddresses.Text, textBoxPhoneNumber.Text))
                {
                    connDB.InsertContact(textBoxName.Text, allAddresses[comboBoxAddresses.SelectedIndex].ID, textBoxPhoneNumber.Text);
                    listViewMain.Refresh();
                }
                else{
                    string error = "Invalid data given in input";
                    FormGenericError dataInputError = new FormGenericError(error);
                    dataInputError.Show();
                }
                ClearTextBoxes();
            }
            LoadAllQueries();
        }

        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null, "Are you sure to delete this record?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                connDB.DeleteContact(int.Parse(textBoxID.Text));
                LoadAllQueries();
                ClearTextBoxes();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            if (ValidateData(textBoxName.Text, comboBoxAddresses.Text, textBoxPhoneNumber.Text))
            {
                connDB.UpdateContact(int.Parse(textBoxID.Text), textBoxName.Text, FetchAddressIDFromString(comboBoxAddresses.Text), textBoxPhoneNumber.Text);
                LoadAllQueries();
                ClearTextBoxes();
            }
            else
            {
                string error = "Invalid data given in input";
                FormGenericError dataInputError = new FormGenericError(error);
                dataInputError.Show();
            }
        }

        private IContact GetSingleContact(int id)
        {
            return connDB.GetContactByID(id);
        }

        private void buttonSearchField_Click(object sender, EventArgs e)
        {
            listViewMain.Items.Clear();
            List<IContact> toShow = connDB.SearchKeywordContact(textBoxSearch.Text);

            foreach (IContact contact in toShow)
            {
                ListViewItem item = new ListViewItem(contact.ID.ToString());
                item.SubItems.Add(contact.Name);
                item.SubItems.Add(contact.Address.ToString());
                item.SubItems.Add(contact.PhoneNumber);
                listViewMain.Items.Add(item);
            }
            listViewMain.Refresh();
        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            buttonDeleteContact.Enabled = false;
            buttonDeleteContact.BackColor = Color.FromName("MenuBar");
            buttonEditContact.Enabled = false;
            buttonEditContact.BackColor = Color.FromName("MenuBar");
            LoadAllQueries();
            ClearTextBoxes();
        }

        private void listViewMain_Click(object sender, EventArgs e)
        {
            if(listViewMain.SelectedItems.Count > 0)
            {
                var item = listViewMain.SelectedItems[0];

                textBoxID.Text = item.Text.ToString();
                textBoxName.Text = item.SubItems[1].Text;
                comboBoxAddresses.Text = item.SubItems[2].Text;
                textBoxPhoneNumber.Text = item.SubItems[3].Text;

                buttonDeleteContact.Enabled = true;
                buttonDeleteContact.BackColor = Color.FromName("Red");
                buttonEditContact.Enabled = true;
                buttonEditContact.BackColor = Color.FromName("Gold");

                this.Refresh();
            }
            
            else
            {
                buttonDeleteContact.Enabled = false;
                buttonDeleteContact.BackColor = Color.FromName("MenuBar");
                buttonEditContact.Enabled = false;
                buttonEditContact.BackColor = Color.FromName("MenuBar");

                buttonDeleteContact.Refresh();
                buttonEditContact.Refresh();
            }
        }

        private void buttonAdditionalData_Click(object sender, EventArgs e)
        {
            FormAddress formAddress = new FormAddress(connDB);
            formAddress.Show();
            LoadAddresses();
        }
    }
}
