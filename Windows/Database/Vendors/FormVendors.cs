using AddressBook.DB;
using AddressBook.Export;
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
        int selectedID = -1;
        int selectedAddress = -1;
        List<IAddress> addresses;
        List<IVendor> allVendors;

        public FormVendors(DBConnection connDB)
        {
            this.connDB = connDB;
            InitializeComponent();
            LoadQueries();
        }

        private void DisableButtons()
        {
            buttonDeleteVendor.Enabled = false;
            buttonDeleteVendor.BackColor = Color.FromName("MenuBar");
            buttonEditVendor.Enabled = false;
            buttonEditVendor.BackColor = Color.FromName("MenuBar");
            buttonDeleteVendor.Refresh();
            buttonEditVendor.Refresh();
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
            comboBoxAddresses.Items.Clear();
            foreach(IAddress singleAddress in addressesToAdd)
            {
                comboBoxAddresses.Items.Add(singleAddress.ToString());
            }
        }

        private void LoadQueries()
        {
            allVendors = new BaseVendor().SelectAllVendors(connDB);
            addresses = new BaseAddress().SelectAllAddresses(connDB);
            LoadAddresses(addresses);
            listViewVendors.Items.Clear();
            foreach (IVendor singleVendor in allVendors)
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
                new BaseVendor().InsertVendor(
                    connDB,
                    new BaseVendor(
                        textBoxName.Text,
                        addresses[comboBoxAddresses.SelectedIndex],
                        textBoxPhoneNumber.Text,
                        textBoxMobilePhone.Text,
                        textBoxWebsite.Text
                        )
                    );
                LoadQueries();
            }
            else
            {
                MessageBox.Show("Couldn't add to the database", "Addition failure");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            new BaseVendor().DeleteVendor(connDB, int.Parse(textBoxID.Text));
            LoadQueries();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                new BaseVendor().UpdateVendor(
                    connDB,
                    new BaseVendor(
                        allVendors[selectedID].ID,
                        textBoxName.Text,
                        addresses[selectedAddress],
                        textBoxPhoneNumber.Text,
                        textBoxMobilePhone.Text,
                        textBoxWebsite.Text
                        )
                    );
                LoadQueries();
            }
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
                IVendor selectedVendor = allVendors[selectedID];
                selectedID = item.Index;
                selectedAddress = selectedVendor.Address.ID - 1;
                textBoxID.Text = item.Text;
                textBoxName.Text = selectedVendor.Name;
                comboBoxAddresses.Text = addresses[selectedVendor.Address.ID - 1].ToString();
                textBoxPhoneNumber.Text = selectedVendor.PhoneNumber;
                textBoxMobilePhone.Text = selectedVendor.MobilePhone;
                textBoxWebsite.Text = selectedVendor.Website;
                buttonDeleteVendor.Enabled = true;
                buttonDeleteVendor.BackColor = Color.FromName("Red");
                buttonEditVendor.Enabled = true;
                buttonEditVendor.BackColor = Color.FromName("Gold");
                this.Refresh();
            }
            else
            {
                selectedAddress = -1;
                selectedID = -1;
                DisableButtons();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DisableButtons();
            textBoxID.Text = "ID";
            textBoxName.Text = "";
            comboBoxAddresses.SelectedIndex = -1;
            textBoxPhoneNumber.Text = "";
            textBoxMobilePhone.Text = "";
            textBoxWebsite.Text = "";
        }

        private void buttonConvertPDF_Click(object sender, EventArgs e)
        {
            List<String> columns = new List<String>();
            columns.Add("Product name");
            columns.Add("Vendor");
            columns.Add("Base price");
            columns.Add("Tax percentage");
            columns.Add("Total price");
            ExportToPdf export = new ExportToPdf(columns, "Vendors");
            foreach (IVendor singleVendor in allVendors)
            {
                List<String> toAdd = new List<String>();
                toAdd.Add(singleVendor.Name);
                toAdd.Add(
                    singleVendor.Address.Street +
                    " " + singleVendor.Address.Number +
                    ", " + singleVendor.Address.PostalCode +
                    " " + singleVendor.Address.Municipality +
                    ", " + singleVendor.Address.Province +
                    ", " + singleVendor.Address.Country
                    );
                toAdd.Add(singleVendor.PhoneNumber);
                toAdd.Add(singleVendor.MobilePhone);
                toAdd.Add(singleVendor.Website);
                export.AddRowElements(toAdd);
            }
            export.SaveFile();
        }
    }
}
