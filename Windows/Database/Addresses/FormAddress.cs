using AddressBook.DB;
using AddressBook.Export;
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

namespace AddressBook.Windows.Address
{
    public partial class FormAddress : Form
    {
        private DBConnection connDB;
        private List<IAddress> allAddresses;
        public FormAddress()
        {
            connDB = new DBConnection();
            InitializeComponent();
            LoadAllQueries();
        }
            
        public FormAddress(DBConnection connDB)
        {
            this.connDB = connDB;
            InitializeComponent();
            LoadAllQueries();
        }

        private void LoadAllQueries()
        {
            listViewAddresses.Items.Clear();
            allAddresses = new BaseAddress().SelectAllAddresses(connDB);
            foreach (IAddress address in allAddresses)
            {
                ListViewItem item = new ListViewItem(address.ID.ToString());
                item.SubItems.Add(address.Street);
                item.SubItems.Add(address.Number);
                item.SubItems.Add(address.PostalCode);
                item.SubItems.Add(address.Municipality);
                item.SubItems.Add(address.Province);
                item.SubItems.Add(address.Country);
                listViewAddresses.Items.Add(item);
            }
            listViewAddresses.Refresh();
        }

        private void ClearTextBoxes()
        {
            textBoxID.Text = "ID";
            textBoxStreet.Text = "";
            textBoxNumber.Text = "";
            textBoxPostalCode.Text = "";
            textBoxMunicipality.Text = "";
            textBoxProvince.Text = "";
            textBoxCountry.Text = "";
            buttonEditAddress.BackColor = Color.FromName("MenuBar");
            buttonDeleteAddress.BackColor = Color.FromName("MenuBar");
            groupBoxActions.Refresh();
        }

        private void DisableButtons()
        {
            buttonEditAddress.Enabled = false;
            buttonEditAddress.BackColor = Color.FromName("MenuBar");
            buttonDeleteAddress.Enabled = false;
            buttonDeleteAddress.BackColor = Color.FromName("MenuBar");
            buttonDeleteAddress.Refresh();
            buttonEditAddress.Refresh();
        }

        private void listViewAddresses_Click(object sender, EventArgs e)
        {
            if(listViewAddresses.SelectedItems.Count > 0)
            {
                var item = listViewAddresses.SelectedItems[0];
                textBoxID.Text = item.Text.ToString();
                textBoxStreet.Text = item.SubItems[1].Text.ToString();
                textBoxNumber.Text = item.SubItems[2].Text.ToString();
                textBoxPostalCode.Text = item.SubItems[3].Text.ToString();
                textBoxMunicipality.Text = item.SubItems[4].Text.ToString();
                textBoxProvince.Text = item.SubItems[5].Text.ToString();
                textBoxCountry.Text = item.SubItems[6].Text.ToString();
                buttonEditAddress.BackColor = Color.FromName("Gold");
                buttonDeleteAddress.BackColor = Color.FromName("Red");
                this.Refresh();
            }
        }

        public bool ValidateData(
            string street,
            string number,
            string postalCode,
            string municipality,
            string province,
            string country
            )
        {
            if (
                string.IsNullOrEmpty(textBoxStreet.Text) ||
                string.IsNullOrEmpty(textBoxNumber.Text) ||
                string.IsNullOrEmpty(textBoxPostalCode.Text) ||
                string.IsNullOrEmpty(textBoxMunicipality.Text) ||
                string.IsNullOrEmpty(textBoxProvince.Text) ||
                string.IsNullOrEmpty(textBoxCountry.Text) ||
                street.Length > 128 ||
                number.Length > 16 ||
                postalCode.Length > 16 ||
                municipality.Length > 128 ||
                province.Length > 128 ||
                country.Length > 128
                ) return false;
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (
                ValidateData(
                    textBoxStreet.Text,
                    textBoxNumber.Text,
                    textBoxPostalCode.Text,
                    textBoxMunicipality.Text,
                    textBoxProvince.Text,
                    textBoxCountry.Text
                    )
                )
            {
                new BaseAddress().InsertAddress(
                    connDB,
                    new BaseAddress(
                        textBoxStreet.Text,
                        textBoxNumber.Text,
                        textBoxPostalCode.Text,
                        textBoxMunicipality.Text,
                        textBoxProvince.Text,
                        textBoxCountry.Text
                        )
                    );
                listViewAddresses.Refresh();
            }
            else MessageBox.Show("Invalid data", "Addition failure");
            LoadAllQueries();
            DisableButtons();
            ClearTextBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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
                new BaseAddress().DeleteAddress(connDB, allAddresses[listViewAddresses.SelectedIndices[0]].ID);
                LoadAllQueries();
                DisableButtons();
                ClearTextBoxes();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (
                ValidateData(
                    textBoxStreet.Text,
                    textBoxNumber.Text,
                    textBoxPostalCode.Text,
                    textBoxMunicipality.Text,
                    textBoxProvince.Text,
                    textBoxCountry.Text)
                )
            {
                new BaseAddress().UpdateAddress(
                    connDB,
                    new BaseAddress(
                        int.Parse(textBoxID.Text),
                        textBoxStreet.Text,
                        textBoxNumber.Text,
                        textBoxPostalCode.Text,
                        textBoxMunicipality.Text,
                        textBoxProvince.Text,
                        textBoxCountry.Text)
                        );
                LoadAllQueries();
                DisableButtons();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Invalid data", "Addition failure");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            List<String> columns = new List<String>();
            columns.Add("ID");
            columns.Add("Street");
            columns.Add("Postal code");
            columns.Add("Municipality");
            columns.Add("Province");
            columns.Add("Country");
            ExportToPdf export = new ExportToPdf(columns, "Addresses");
            foreach (IAddress singleAddress in allAddresses)
            {
                List<String> toAdd = new List<String>();
                toAdd.Add(singleAddress.ID.ToString());
                toAdd.Add(singleAddress.Street + ", " + singleAddress.Number);
                toAdd.Add(singleAddress.PostalCode);
                toAdd.Add(singleAddress.Municipality);
                toAdd.Add(singleAddress.Province);
                toAdd.Add(singleAddress.Country);
                export.AddRowElements(toAdd);
            }
            export.SaveFile();
        }
    }
}
