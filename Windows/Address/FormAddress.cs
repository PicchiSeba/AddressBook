using AddressBook.DB;
using AddressBook.Model;
using AddressBook.Windows.Errors;
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
        DBConnection connDB;

        public FormAddress(DBConnection connDB)
        {
            this.connDB = connDB;

            InitializeComponent();
            LoadAllQueries();
        }

        private void LoadAllQueries()
        {
            listViewAddresses.Items.Clear();

            List<IAddress> allAddresses = connDB.SelectAllAddresses();

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
            textBoxID.Text = "";
            textBoxStreet.Text = "";
            textBoxNumber.Text = "";
            textBoxPostalCode.Text = "";
            textBoxMunicipality.Text = "";
            textBoxProvince.Text = "";
            textBoxCountry.Text = "";

            groupBoxActions.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

                this.Refresh();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(textBoxStreet.Text) ||
                string.IsNullOrEmpty(textBoxNumber.Text) ||
                string.IsNullOrEmpty(textBoxPostalCode.Text) ||
                string.IsNullOrEmpty(textBoxMunicipality.Text) ||
                string.IsNullOrEmpty(textBoxProvince.Text) ||
                string.IsNullOrEmpty(textBoxCountry.Text)
                )
            {

            }
            else
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
                    connDB.InsertAddress(
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
                else
                {
                    string error = "Invalid data given in input";
                    FormGenericError dataInputError = new FormGenericError(error);
                    dataInputError.Show();
                }
            }
            LoadAllQueries();
            ClearTextBoxes();
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
            if (street.Length > 128) return false;
            if (number.Length > 16) return false;
            if (number.Length > 16) return false;
            if (number.Length > 128) return false;
            if (number.Length > 128) return false;
            if (number.Length > 128) return false;

            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null, "Are you sure to delete this record?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                connDB.DeleteAddress(int.Parse(textBoxID.Text));
                LoadAllQueries();
                ClearTextBoxes();
            }
            else if (result == DialogResult.No)
            {

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
                connDB.UpdateAddress(
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
                ClearTextBoxes();
            }
            else
            {
                string error = "Invalid data given in input";
                FormGenericError dataInputError = new FormGenericError(error);
                dataInputError.Show();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
