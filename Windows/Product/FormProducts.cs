using AddressBook.DB;
using AddressBook.Models;
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

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }
    }
}
