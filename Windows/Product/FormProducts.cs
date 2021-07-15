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
        private DBConnection connDB = new DBConnection();
        private List<IProduct> products;
        private List<IVendor> vendors;

        public FormProducts()
        {
            InitializeComponent();
            LoadQueries();
        }

        private void LoadQueries()
        {
            products = connDB.SelectAllProducts();
            vendors = connDB.SelectAllVendors();

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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "ID";
            textBoxName.Text = "";
            textBoxPriceUntaxed.Text = "";
            textBoxTaxPercentage.Text = "";
            textBoxReference.Text = "";
            textBoxBarcode.Text = "";
            comboBoxVendor.SelectedIndex = -1;

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

                foreach (IVendor singleVendor in vendors)
                {
                    if(singleVendor.ID == selectedProduct.Vendor.ID)
                    {

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
    }
}
