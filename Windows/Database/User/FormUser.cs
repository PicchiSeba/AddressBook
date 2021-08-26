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
using AddressBook.Export;
using AddressBook.Model;
using AddressBook.Windows.Address;
namespace AddressBook
{
    public partial class FormUser : Form
    {
        private DBConnection connDB;
        private List<IAddress> allAddresses;
        private List<IContact> allUsers;

        public FormUser(DBConnection connDB)
        {
            this.connDB = connDB;
            InitializeComponent();
            LoadAllQueries();
            LoadAddresses();
        }

        private void LoadAllQueries()
        {
            listViewUsers.Items.Clear();
            allUsers = new List<IContact>();
            List<IContact> allContacts = new BaseContact().SelectAllContacts(connDB);
            foreach(IContact contact in allContacts)
            {
                allUsers.Add(contact);
            }
            foreach (IContact singleContact in allUsers)
            {
                ListViewItem item = new ListViewItem(singleContact.ID.ToString());
                item.SubItems.Add(singleContact.Name);
                item.SubItems.Add(singleContact.Address.ToString());
                item.SubItems.Add(singleContact.PhoneNumber);
                listViewUsers.Items.Add(item);
            }
            listViewUsers.Refresh();
        }

        private void LoadAddresses()
        {
            comboBoxAddresses.Items.Clear();
            allAddresses = new BaseAddress().SelectAllAddresses(connDB);
            foreach(IAddress singleAddress in allAddresses)
            {
                string outputInTheList = "[" + singleAddress.ID + "] " +
                    singleAddress.Street + " " +
                    singleAddress.Number + ", " +
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
            comboBoxAddresses.SelectedIndex = -1;
            textBoxPhoneNumber.Text = "";
            textBoxSearch.Text = "";
            textBoxID.Text = "ID";
            groupBoxActions.Refresh();
        }

        private void DisableButtons()
        {
            buttonEditContact.Enabled = false;
            buttonEditContact.BackColor = Color.FromName("MenuBar");
            buttonDeleteContact.Enabled = false;
            buttonDeleteContact.BackColor = Color.FromName("MenuBar");
            buttonDeleteContact.Refresh();
            buttonEditContact.Refresh();
        }

        private bool ValidateData(string name, string phoneNumber)
        {
            if (
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(phoneNumber) ||
                name.Length > 128 ||
                phoneNumber.Length > 16
                )
                return false;
            foreach(char singleChar in phoneNumber)
            {
                bool isANumber = false;
                for(int i = 0; i < 10; i++)
                {
                    if (char.IsDigit(singleChar))
                    {
                        isANumber = true;
                        break;
                    }
                }
                if (!isANumber) return false;
            }
            return true;
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            if (ValidateData(textBoxName.Text, textBoxPhoneNumber.Text))
                {
                    new BaseContact().InsertContact(
                        connDB,
                        new BaseContact(
                            allAddresses[comboBoxAddresses.SelectedIndex].ID,
                            textBoxName.Text,
                            allAddresses[comboBoxAddresses.SelectedIndex],
                            textBoxPhoneNumber.Text
                            )
                        );
                    listViewUsers.Refresh();
            }
            else{
                MessageBox.Show("Invalid data. Couldn't add to the database", "Addition failure");
            }
            DisableButtons();
            ClearTextBoxes();
            LoadAllQueries();
        }

        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                null,
                "Are you sure to delete this record?",
                "Confirm deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                new BaseContact().DeleteContact(connDB, int.Parse(textBoxID.Text));
                LoadAllQueries();
                DisableButtons();
                ClearTextBoxes();
            }
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            if (ValidateData(textBoxName.Text, textBoxPhoneNumber.Text))
            {
                new BaseContact().UpdateContact(
                    connDB,
                    new BaseContact(
                        int.Parse(textBoxID.Text),
                        textBoxName.Text,
                        allAddresses[comboBoxAddresses.SelectedIndex],
                        textBoxPhoneNumber.Text
                        )
                    );
                LoadAllQueries();
                DisableButtons();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Couldn't edit from the database", "Edit failure");
            }
        }

        private void buttonSearchField_Click(object sender, EventArgs e)
        {
            listViewUsers.Items.Clear();
            List<IContact> toShow = new BaseContact().SearchKeywordContact(connDB, textBoxSearch.Text);
            foreach (IContact contact in toShow)
            {
                ListViewItem item = new ListViewItem(contact.ID.ToString());
                item.SubItems.Add(contact.Name);
                item.SubItems.Add(contact.Address.ToString());
                item.SubItems.Add(contact.PhoneNumber);
                listViewUsers.Items.Add(item);
            }
            listViewUsers.Refresh();
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
            if(listViewUsers.SelectedItems.Count > 0)
            {
                var item = listViewUsers.SelectedItems[0];
                textBoxID.Text = item.Text;
                textBoxName.Text = allUsers[listViewUsers.SelectedIndices[0]].Name;
                for(int index = 0; index < allAddresses.Count; index++)
                {
                    if(allUsers[listViewUsers.SelectedIndices[0]].Address.ID == allAddresses[index].ID)
                    {
                        comboBoxAddresses.SelectedIndex = index;
                        break;
                    }
                }
                textBoxPhoneNumber.Text = allUsers[listViewUsers.SelectedIndices[0]].PhoneNumber;
                buttonDeleteContact.Enabled = true;
                buttonDeleteContact.BackColor = Color.FromName("Red");
                buttonEditContact.Enabled = true;
                buttonEditContact.BackColor = Color.FromName("Gold");
                this.Refresh();
            }
            else
            {
                DisableButtons();
            }
        }

        private void buttonAdditionalData_Click(object sender, EventArgs e)
        {
            FormAddress formAddress = new FormAddress(connDB);
            formAddress.ShowDialog();
            LoadAddresses();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            List<String> columns = new List<String>();
            columns.Add("ID");
            columns.Add("Name");
            columns.Add("Address");
            columns.Add("Phone number");
            ExportToPdf export = new ExportToPdf(columns, "Users");
            foreach(IContact singleUser in allUsers)
            {
                List<String> toAdd = new List<String>();
                toAdd.Add(singleUser.ID.ToString());
                toAdd.Add(singleUser.Name);
                toAdd.Add(singleUser.Address.ToString());
                toAdd.Add(singleUser.PhoneNumber);
                export.AddRowElements(toAdd);
            }
            export.SaveFile();
        }
    }
}
