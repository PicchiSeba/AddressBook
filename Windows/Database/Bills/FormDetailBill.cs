using AddressBook.DB;
using AddressBook.Models;
using AddressBook.Models.BaseClasses;
using AddressBook.Windows.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Windows.Bills
{
    public partial class FormBillDetail : Form
    {
        private DBConnection connDB;
        private IMasterBill masterBill;
        private List<IBillDetail> allBillDetails = new List<IBillDetail>();
        private List<IProduct> allProducts = new List<IProduct>();

        public FormBillDetail(IMasterBill masterBill, DBConnection connDB)
        {
            this.connDB = connDB;
            this.masterBill = masterBill;
            InitializeComponent();
            LoadQueries();
        }

        private void LoadQueries()
        {
            listViewBillsDetailBill.Items.Clear();
            listViewProductsDetailBill.Items.Clear();
            allBillDetails = new BaseBillDetail().FindRelatedBills(connDB, masterBill.ID);
            foreach(IBillDetail singleBillDetail in allBillDetails)
            {
                ListViewItem item = new ListViewItem();
                item.Text = singleBillDetail.IDBill.ToString();
                item.SubItems.Add(singleBillDetail.Product.ID.ToString());
                item.SubItems.Add(singleBillDetail.Units.ToString());
                item.SubItems.Add(singleBillDetail.Product.Name);
                item.SubItems.Add(singleBillDetail.Product.PriceUntaxed.ToString());
                item.SubItems.Add(singleBillDetail.Product.PriceTaxed.ToString());
                listViewBillsDetailBill.Items.Add(item);
            }
            allProducts = new BaseProduct().SelectAllProducts(connDB);
            foreach(IProduct singleProduct in allProducts)
            {
                ListViewItem item = new ListViewItem();
                item.Text = singleProduct.ID.ToString();
                item.SubItems.Add(singleProduct.Name);
                item.SubItems.Add(singleProduct.PriceUntaxed.ToString());
                item.SubItems.Add(singleProduct.TaxPercentage.ToString() + " %");
                item.SubItems.Add(singleProduct.PriceTaxed.ToString());
                listViewProductsDetailBill.Items.Add(item);
            }
        }

        private void EnableButtons()
        {
            buttonDeleteBillDetail.Enabled = true;
            buttonDeleteBillDetail.BackColor = Color.FromName("Red");
            buttonEditBillDetail.Enabled = true;
            buttonEditBillDetail.BackColor = Color.FromName("Gold");
            buttonDeleteBillDetail.Refresh();
            buttonEditBillDetail.Refresh();
        }

        private void ResetTextBoxID()
        {
            textBoxID.Text = "ID";
            textBoxUnitsBillDetail.Text = "";
        }

        private void DisableButtons()
        {
            ResetTextBoxID();
            buttonDeleteBillDetail.Enabled = false;
            buttonDeleteBillDetail.BackColor = Color.FromName("MenuBar");
            buttonEditBillDetail.Enabled = false;
            buttonEditBillDetail.BackColor = Color.FromName("MenuBar");
            buttonDeleteBillDetail.Refresh();
            buttonEditBillDetail.Refresh();
        }

        private void EnableAddButton()
        {
            buttonAddBillDetail.Enabled = true;
            buttonAddBillDetail.BackColor = Color.FromName("Lime");
            buttonAddBillDetail.Refresh();
        }

        private void DisableAddButton()
        {
            ResetTextBoxID();
            buttonAddBillDetail.Enabled = false;
            buttonAddBillDetail.BackColor = Color.FromName("MenuBar");
            buttonAddBillDetail.Refresh();
        }

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(textBoxUnitsBillDetail.Text) ||
                Convert.ToInt32(textBoxUnitsBillDetail.Text) < 1
                ) return false;
            return true;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewBillsDetailBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewBillsDetailBill.SelectedItems.Count > 0)
            {
                int index = listViewBillsDetailBill.SelectedIndices[0];
                EnableButtons();
                textBoxID.Text = allBillDetails[index].IDBill.ToString();
                textBoxUnitsBillDetail.Text = allBillDetails[index].Units.ToString();
            }
            else
            {
                DisableButtons();
            }
        }

        private void listViewProductsDetailBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewProductsDetailBill.SelectedItems.Count > 0)
            {
                int index = listViewProductsDetailBill.SelectedIndices[0];
                EnableAddButton();
                textBoxID.Text = allProducts[index].ID.ToString();
            }
            else
            {
                DisableAddButton();
            }
        }

        private void buttonAddBillDetail_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                new BaseBillDetail().InsertBillDetail(
                    connDB,
                    new BaseBillDetail(
                        allProducts[listViewProductsDetailBill.SelectedIndices[0]],
                        Convert.ToInt32(textBoxUnitsBillDetail.Text)
                        ),
                    masterBill.ID
                    );
                LoadQueries();
            }
            else
                MessageBox.Show("Invalid data. Couldn't add to the database", "Addition failure");
        }

        private void buttonEditBillDetail_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                foreach (IBillDetail singleBillDetail in allBillDetails)
                {
                    if (singleBillDetail.IDBill == Convert.ToInt32(textBoxID.Text))
                    {
                        new BaseBillDetail().UpdateBillDetail(
                            connDB,
                            new BaseBillDetail(
                                singleBillDetail.IDBill,
                                singleBillDetail.Product,
                                Convert.ToInt32(textBoxUnitsBillDetail.Text)
                                ),
                            masterBill.ID
                            );
                        break;
                    }
                }
                LoadQueries();
            }
            else
                MessageBox.Show("Invalid data. Couldn't update the database", "Update failure");
        }

        private void buttonDeleteBillDetail_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null, "Are you sure to delete this record?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new BaseBillDetail().DeleteBillDetail(
                    connDB,
                    allBillDetails[listViewBillsDetailBill.SelectedIndices[0]].IDBill
                    );
                LoadQueries();
            }
        }

        private void buttonProductPageBillDetail_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(connDB);
            formProducts.ShowDialog();
            LoadQueries();
        }
    }
}
