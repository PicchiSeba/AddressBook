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

namespace AddressBook.Windows.Bills
{
    public partial class FormBills : Form
    {
        private DBConnection connDB = new DBConnection();
        private List<IMasterBill> allMasterBills;
        private List<IVendor> allVendors;
        private List<string> allPaymentMethods;

        public FormBills()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.Refresh();
            LoadQueries();
        }

        private void LoadQueries()
        {
            listViewBillMasters.Items.Clear();
            comboBoxVendors.Items.Clear();
            comboBoxPaymentMethod.Items.Clear();
            allMasterBills = connDB.SelectAllMasterBills();
            allPaymentMethods = new List<string>();
            foreach (IMasterBill singleBillMaster in allMasterBills)
            {
                bool alreadyPresent = false;
                ListViewItem item = new ListViewItem();
                item.UseItemStyleForSubItems = false;
                item.ForeColor = Color.FromName("Windows Text");
                item.Text = singleBillMaster.ID.ToString();
                item.SubItems.Add(singleBillMaster.BillNumber);
                item.SubItems.Add(singleBillMaster.Date.ToShortDateString());
                item.SubItems.Add(singleBillMaster.Vendor.ToString());
                item.SubItems.Add(singleBillMaster.BasePrice.ToString());
                if (singleBillMaster.TaxPercentage.ToString() == "NaN") item.SubItems.Add("0");
                else item.SubItems.Add(singleBillMaster.TaxPercentage.ToString() + " %");
                if (singleBillMaster.TotalPrice.ToString() == "NaN") item.SubItems.Add("0");
                else item.SubItems.Add(singleBillMaster.TotalPrice.ToString());
                if (singleBillMaster.Paid)
                {
                    item.SubItems.Add("YES");
                    item.SubItems[7].ForeColor = Color.FromName("Lime");
                }
                else
                {
                    item.SubItems.Add("NO");
                    item.SubItems[7].ForeColor = Color.FromName("Red");
                }
                item.ForeColor = Color.FromName("Windows Text");
                item.SubItems.Add(singleBillMaster.PaymentMethod);
                listViewBillMasters.Items.Add(item);
                foreach(string singleMethod in allPaymentMethods)
                    if (singleMethod == singleBillMaster.PaymentMethod)
                        alreadyPresent = true;
                if (!alreadyPresent)
                    allPaymentMethods.Add(singleBillMaster.PaymentMethod);
            }
            comboBoxVendors.Items.Clear();
            allVendors = connDB.SelectAllVendors();
            foreach(IVendor singleVendor in allVendors)
                comboBoxVendors.Items.Add(singleVendor.ToString());
            allPaymentMethods.Add("Other(specify)");
            foreach(string singleMethod in allPaymentMethods)
                comboBoxPaymentMethod.Items.Add(singleMethod);
            groupBoxActions.Refresh();
            listViewBillMasters.Refresh();
        }

        private bool ValidateData()
        {
            return true;
        }

        private void EnableButtons()
        {
            buttonDeleteBill.Enabled = true;
            buttonDeleteBill.BackColor = Color.FromName("Red");
            buttonEditBill.Enabled = true;
            buttonEditBill.BackColor = Color.FromName("Gold");
            buttonDetailsBill.Enabled = true;
            buttonDeleteBill.Refresh();
            buttonEditBill.Refresh();
        }

        private void ResetGroupBoxAction()
        {
            DisableButtons();
            textBoxIDBill.Text = "ID";
            textBoxBillNumber.Text = "";
            comboBoxVendors.SelectedIndex = -1;
            comboBoxPaymentMethod.SelectedIndex = -1;
            textBoxPaymentMethodBill.Text = "";
            checkBoxPaid.Checked = false;
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            groupBoxActions.Refresh();
        }

        private void DisableButtons()
        {
            buttonDeleteBill.Enabled = false;
            buttonDeleteBill.BackColor = Color.FromName("MenuBar");
            buttonEditBill.Enabled = false;
            buttonEditBill.BackColor = Color.FromName("MenuBar");
            buttonDetailsBill.Enabled = false;
            buttonDeleteBill.Refresh();
            buttonEditBill.Refresh();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewBillMasters_Click(object sender, EventArgs e)
        {
            if(listViewBillMasters.SelectedItems.Count > 0)
            {
                int indexMasterBill = listViewBillMasters.SelectedIndices[0];
                textBoxIDBill.Text = allMasterBills[indexMasterBill].ID.ToString();
                textBoxBillNumber.Text = allMasterBills[indexMasterBill].BillNumber;
                dateTimePicker1.Value = allMasterBills[indexMasterBill].Date;
                for (int index = 0; index < allVendors.Count; index++)
                    if (allVendors[index].ID == allMasterBills[indexMasterBill].Vendor.ID)
                    {
                        comboBoxVendors.SelectedIndex = index;
                        break;
                    }
                for(int index = 0; index < allPaymentMethods.Count; index++)
                {
                    if(allMasterBills[indexMasterBill].PaymentMethod == allPaymentMethods[index])
                    {
                        comboBoxPaymentMethod.SelectedIndex = index;
                        break;
                    }
                }
                checkBoxPaid.Checked = allMasterBills[indexMasterBill].Paid;
                EnableButtons();
            }
            else
                ResetGroupBoxAction();
        }

        private void buttonAddBill_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                connDB.InsertMasterBill(
                    new BaseMasterBill(
                        textBoxBillNumber.Text,
                        dateTimePicker1.Value,
                        allVendors[comboBoxVendors.SelectedIndex],
                        Convert.ToInt32(checkBoxPaid.Checked),
                        comboBoxPaymentMethod.Text
                        )
                    );
                LoadQueries();
            }
            else
                MessageBox.Show("Invalid data. Couldn't add to the database", "Addition failure");
        }

        private void buttonEditBill_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                connDB.UpdateMasterBill(
                    new BaseMasterBill(
                        Convert.ToInt32(textBoxIDBill.Text),
                        textBoxBillNumber.Text,
                        dateTimePicker1.Value,
                        allVendors[comboBoxVendors.SelectedIndex],
                        Convert.ToInt32(checkBoxPaid.Checked),
                        comboBoxPaymentMethod.Text
                        )
                    );
                LoadQueries();
            }
            else
                MessageBox.Show("Invalid data. Couldn't update the database", "Update failure");
        }

        private void buttonDeleteBill_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null, "Are you sure to delete this record?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                connDB.DeleteMasterBill(Convert.ToInt32(textBoxIDBill.Text));
                LoadQueries();
                ResetGroupBoxAction();
            }
        }

        private void buttonDetailsBill_Click(object sender, EventArgs e)
        {
            FormBillDetail formDetailBill = new FormBillDetail(allMasterBills[listViewBillMasters.SelectedIndices[0]]);
            formDetailBill.ShowDialog();
            LoadQueries();
        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPaymentMethod.Text == "Other(specify)")
            {
                textBoxPaymentMethodBill.Enabled = true;
                textBoxPaymentMethodBill.Refresh();
            }
            else
            {
                textBoxPaymentMethodBill.Enabled = false;
                textBoxPaymentMethodBill.Refresh();
            }
        }
    }
}
