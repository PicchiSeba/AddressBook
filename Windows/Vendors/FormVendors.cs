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

        public FormVendors()
        {
            connDB = new DBConnection();
            InitializeComponent();
            LoadQueries();
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

        private void LoadQueries()
        {
            listViewVendors.Items.Clear();

            List<IVendor> vendors = connDB.SelectVendors();

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
                        addresses[comboBoxAddress.SelectedIndex],
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
    }
}
