using AddressBook.DB;
using AddressBook.Model;
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

namespace AddressBook.Windows.Vendors
{
    public partial class FormVendors : Form
    {
        DBConnection connDB;
        List<IAddress> addresses;
        List<IVendor> vendors;

        public FormVendors()
        {
            connDB = new DBConnection();
            InitializeComponent();
            LoadQueries();
        }

        private void DisableButtons()
        {
            buttonDelete.Enabled = false;
            buttonDelete.BackColor = Color.FromName("MenuBar");
            buttonEdit.Enabled = false;
            buttonEdit.BackColor = Color.FromName("MenuBar");
        }

        private bool ValidateData()
        {
            if (
                string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxPhoneNumber.Text) ||
                string.IsNullOrEmpty(textBoxMobilePhone.Text) ||
                string.IsNullOrEmpty(textBoxWebsite.Text) ||
                textBoxName.Text.Length > 128 ||
                textBoxPhoneNumber.Text.Length > 16 ||
                textBoxMobilePhone.Text.Length > 16 ||
                !CheckIfPhoneNumber(textBoxPhoneNumber.Text) ||
                !CheckIfPhoneNumber(textBoxMobilePhone.Text)
                )
                return false;
            return true;
        }

        private bool CheckIfPhoneNumber(string phoneNumber)
        {
            bool isANumber;

            foreach (char singleChar in phoneNumber)
            {
                isANumber = false;
                for (int i = 0; i < 10; i++)
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

        private void LoadAddresses(List<IAddress> addressesToAdd)
        {
            foreach(IAddress singleAddress in addressesToAdd)
            {
                comboBoxAddresses.Items.Add(singleAddress.ToString());
            }
        }

        private void LoadQueries()
        {
            vendors = connDB.SelectAllVendors();
            addresses = connDB.SelectAllAddresses();
            LoadAddresses(addresses);
            listViewVendors.Items.Clear();

            foreach (IVendor singleVendor in vendors)
            {
                ListViewItem item = new ListViewItem(singleVendor.ID.ToString());
                item.SubItems.Add(singleVendor.Name);
                item.SubItems.Add(
                    singleVendor.Address.Street + " " +
                    singleVendor.Address.Number
                    );
                item.SubItems.Add(singleVendor.Address.Municipality);
                item.SubItems.Add(singleVendor.Address.PostalCode);
                item.SubItems.Add(singleVendor.Address.Province);
                item.SubItems.Add(singleVendor.PhoneNumber);
                item.SubItems.Add(singleVendor.MobilePhone);
                item.SubItems.Add(singleVendor.Website);
                listViewVendors.Items.Add(item);
            }

            listViewVendors.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                connDB.AddVendor(
                    new BaseVendor(
                        textBoxName.Text,
                        addresses[comboBoxAddresses.SelectedIndex],
                        textBoxPhoneNumber.Text,
                        textBoxMobilePhone.Text,
                        textBoxWebsite.Text
                        )
                    );
            }
            else
            {
                MessageBox.Show("Couldn't add to the database", "Addition failure");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewVendors_Click(object sender, EventArgs e)
        {
            if (listViewVendors.SelectedItems.Count > 0)
            {
                var item = listViewVendors.SelectedItems[0];

                int id = int.Parse(item.Text);

                textBoxID.Text = item.Text;
                textBoxName.Text = vendors[id].Name;
                comboBoxAddresses.Text = addresses[
                        vendors[id].Address.ID - 1
                    ].ToString();
                textBoxPhoneNumber.Text = vendors[id].PhoneNumber;
                textBoxMobilePhone.Text = vendors[id].MobilePhone;
                textBoxWebsite.Text = vendors[id].Website;

                buttonDelete.Enabled = true;
                buttonDelete.BackColor = Color.FromName("Red");
                buttonEdit.Enabled = true;
                buttonEdit.BackColor = Color.FromName("Gold");

                this.Refresh();
            }
            else
            {
                DisableButtons();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DisableButtons();
        }
    }
}
