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

namespace AddressBook.Windows.Bills
{
    public partial class FormBills : Form
    {
        private DBConnection connDB = new DBConnection();
        private List<IBillMaster> allBillMasters;

        public FormBills()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.Refresh();
            LoadQueries();
        }

        private void LoadQueries()
        {
            allBillMasters = connDB.AllMasterBills();

            foreach (IBillMaster singleBillMaster in allBillMasters)
            {
                ListViewItem item = new ListViewItem();
                item.UseItemStyleForSubItems = false;
                item.ForeColor = Color.FromName("Windows Text");
                item.Text = singleBillMaster.ID.ToString();
                item.SubItems.Add(singleBillMaster.BillNumber);
                item.SubItems.Add(singleBillMaster.Date.ToShortDateString());
                item.SubItems.Add(singleBillMaster.Vendor.ToString());
                item.SubItems.Add(singleBillMaster.BasePrice.ToString());
                item.SubItems.Add(singleBillMaster.TaxPercentage.ToString());
                item.SubItems.Add(singleBillMaster.TotalPrice.ToString());
                if (singleBillMaster.Paid)
                {
                    item.SubItems.Add("Paid");
                    item.SubItems[7].ForeColor = Color.FromName("Lime");
                }
                else
                {
                    item.SubItems.Add("Not paid");
                    item.SubItems[5].ForeColor = Color.FromName("Red");
                }
                item.ForeColor = Color.FromName("Windows Text");
                item.SubItems.Add(singleBillMaster.PaymentForm);
                listViewBillMasters.Items.Add(item);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
