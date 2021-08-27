using AddressBook.DB;
using AddressBook.Export;
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
        private DBConnection connDB;
        private List<IMasterBill> allMasterBills;
        private List<IVendor> allVendors;
        private List<string> allPaymentMethods;

        public FormBills(DBConnection connDB)
        {
            this.connDB = connDB;
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
            allMasterBills = new BaseMasterBill().SelectAllMasterBills(connDB);
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
                if (singleBillMaster.TotalPrice.ToString() == "NaN") item.SubItems.Add("0");
                else item.SubItems.Add(singleBillMaster.TotalPrice.ToString());
                if (singleBillMaster.Paid)
                {
                    item.SubItems.Add("YES");
                    item.SubItems[5].ForeColor = Color.FromName("Lime");
                }
                else
                {
                    item.SubItems.Add("NO");
                    item.SubItems[5].ForeColor = Color.FromName("Red");
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
            allVendors = new BaseVendor().SelectAllVendors(connDB);
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
                new BaseMasterBill().InsertMasterBill(
                    connDB,
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
                new BaseMasterBill().UpdateMasterBill(
                    connDB,
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
                new BaseMasterBill().DeleteMasterBill(
                    connDB,
                    Convert.ToInt32(textBoxIDBill.Text)
                    );
                LoadQueries();
                ResetGroupBoxAction();
            }
        }

        private void buttonDetailsBill_Click(object sender, EventArgs e)
        {
            FormBillDetail formDetailBill = new FormBillDetail(
                allMasterBills[listViewBillMasters.SelectedIndices[0]],
                connDB
                );
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

        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            List<String> columns = new List<String>();
            columns.Add("Bill number");
            columns.Add("Date");
            columns.Add("Vendor");
            columns.Add("Total price");
            columns.Add("Paid?");
            columns.Add("Payment method");
            ExportToPdf export = new ExportToPdf(columns, "Master bills");
            foreach (IMasterBill singleMasterBill in allMasterBills)
            {
                List<String> toAdd = new List<String>();
                toAdd.Add(singleMasterBill.BillNumber);
                toAdd.Add(singleMasterBill.Date.ToShortDateString());
                toAdd.Add(singleMasterBill.Vendor.Name);
                toAdd.Add(singleMasterBill.TotalPrice.ToString() + " $");
                if (singleMasterBill.Paid)
                {
                    toAdd.Add("YES");
                    if (string.IsNullOrEmpty(singleMasterBill.PaymentMethod))
                        toAdd.Add("-");
                    else
                        toAdd.Add(singleMasterBill.PaymentMethod);
                }
                else
                {
                    toAdd.Add("NO");
                    toAdd.Add("-");
                }
                export.AddRowElements(toAdd);
            }
            export.SaveFile();
        }
    }
}
