using AddressBook.DB;
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

namespace AddressBook.Windows.Product
{
    public partial class FormProducts : Form
    {
        private DBConnection connDB;
        private List<IProduct> products;
        private List<IVendor> vendors;

        public FormProducts(DBConnection connDB)
        {
            this.connDB = connDB;
            InitializeComponent();
            LoadQueries();
        }

        private void LoadQueries()
        {
            comboBoxVendor.Items.Clear();
            listViewProducts.Items.Clear();
            products = new BaseProduct().SelectAllProducts(connDB);
            vendors = new BaseVendor().SelectAllVendors(connDB);
            foreach(IVendor singleVendor in vendors)
            {
                comboBoxVendor.Items.Add(
                    "[" + singleVendor.ID + "] " +
                    singleVendor.Name
                    );
            }
            foreach (IProduct singleProduct in products)
            {
                ListViewItem item = new ListViewItem(singleProduct.ID.ToString());
                item.SubItems.Add(singleProduct.Name);
                item.SubItems.Add(singleProduct.PriceUntaxed.ToString());
                item.SubItems.Add(singleProduct.TaxPercentage.ToString());
                item.SubItems.Add(singleProduct.PriceTaxed.ToString());
                item.SubItems.Add(singleProduct.Reference);
                item.SubItems.Add(singleProduct.Barcode);
                item.SubItems.Add(singleProduct.Vendor.ToString());
                listViewProducts.Items.Add(item);
            }
        }

        private bool ValidateData()
        {
            if (
                string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxPriceUntaxed.Text) ||
                string.IsNullOrEmpty(textBoxTaxPercentage.Text) ||
                string.IsNullOrEmpty(textBoxReference.Text) ||
                string.IsNullOrEmpty(textBoxBarcode.Text) ||
                textBoxName.Text.Length > 128 ||
                Convert.ToSingle(textBoxPriceUntaxed.Text) < 0 ||
                Convert.ToSingle(textBoxTaxPercentage.Text) < 0 ||
                textBoxReference.Text.Length > 128 ||
                textBoxBarcode.Text.Length > 128
                ) return false;
            return true;
        }

        private void EnableButtons()
        {
            buttonEditProduct.Enabled = true;
            buttonEditProduct.BackColor = Color.FromName("Gold");
            buttonEditProduct.Refresh();
            buttonDeleteProduct.Enabled = true;
            buttonDeleteProduct.BackColor = Color.FromName("Red");
            buttonDeleteProduct.Refresh();
        }

        private void DisableButtons()
        {
            buttonEditProduct.Enabled = false;
            buttonEditProduct.BackColor = Color.FromName("MenuBar");
            buttonEditProduct.Refresh();
            buttonDeleteProduct.Enabled = false;
            buttonDeleteProduct.BackColor = Color.FromName("MenuBar");
            buttonDeleteProduct.Refresh();
        }

        private void ClearTextBoxes()
        {
            textBoxID.Text = "ID";
            textBoxName.Text = "";
            textBoxPriceUntaxed.Text = "";
            textBoxTaxPercentage.Text = "";
            textBoxReference.Text = "";
            textBoxBarcode.Text = "";
            comboBoxVendor.SelectedIndex = -1;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            DisableButtons();
            groupBoxActions.Refresh();
        }

        private void listViewProducts_Click(object sender, EventArgs e)
        {
            if(listViewProducts.SelectedItems.Count > 0)
            {
                IProduct selectedProduct = products[listViewProducts.SelectedIndices[0]];
                textBoxID.Text = selectedProduct.ID.ToString();
                textBoxName.Text = selectedProduct.Name;
                textBoxPriceUntaxed.Text = selectedProduct.PriceUntaxed.ToString();
                textBoxTaxPercentage.Text = selectedProduct.TaxPercentage.ToString();
                textBoxReference.Text = selectedProduct.Reference;
                textBoxBarcode.Text = selectedProduct.Barcode;
                for(int index = 0; index < vendors.Count; index++)
                {
                    if (vendors[index].ID == selectedProduct.Vendor.ID)
                    {
                        comboBoxVendor.SelectedIndex = index;
                        break;
                    }
                }
                EnableButtons();
            }
            else
            {
                DisableButtons();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                new BaseProduct().InsertProduct(
                    connDB,
                    new BaseProduct(
                        textBoxName.Text,
                        Convert.ToSingle(textBoxPriceUntaxed.Text),
                        Convert.ToSingle(textBoxTaxPercentage.Text),
                        textBoxReference.Text,
                        textBoxBarcode.Text,
                        vendors[comboBoxVendor.SelectedIndex]
                        )
                    );
                LoadQueries();
            }
            else
            {
                MessageBox.Show("Invalid data. Couldn't add to the database", "Addition failure");
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
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
                new BaseProduct().DeleteProduct(connDB, int.Parse(textBoxID.Text));
                LoadQueries();
                DisableButtons();
                ClearTextBoxes();
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                new BaseProduct().UpdateProduct(
                    connDB,
                    new BaseProduct(
                        Convert.ToInt32(textBoxID.Text),
                        textBoxName.Text,
                        Convert.ToSingle(textBoxPriceUntaxed.Text),
                        Convert.ToSingle(textBoxTaxPercentage.Text),
                        textBoxReference.Text,
                        textBoxBarcode.Text,
                        vendors[comboBoxVendor.SelectedIndex]
                        )
                    );
                LoadQueries();
            }
            else
            {
                MessageBox.Show("Invalid data. Couldn't add to the database", "Addition failure");
            }
        }
    }
}
