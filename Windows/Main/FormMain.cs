using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook.DB;
using AddressBook.Windows.Address;
using AddressBook.Windows.Bills;
using AddressBook.Windows.Payments;
using AddressBook.Windows.Product;
using AddressBook.Windows.Settings.Database;
using AddressBook.Windows.Vendors;

namespace AddressBook.Windows.Main
{
    public partial class FormMain : Form
    {
        DBConnection connDB;
        public FormMain(bool admin, DBConnection connDB)
        {
            InitializeComponent();
            if (admin)
            {
                ToolStripItem toAdd = new ToolStripMenuItem();
                toAdd.Text = "Users management";
                toAdd.Click += new EventHandler(UsersManagementClick);
                windowToolStripMenuItem.DropDownItems.Add(toAdd);
            }
            windowToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            ToolStripItem exitButton = new ToolStripMenuItem();
            exitButton.Text = "Exit";
            exitButton.Click += new EventHandler(ExitWindow);
            windowToolStripMenuItem.DropDownItems.Add(exitButton);
            this.connDB = connDB;
        }

        private void UsersManagementClick(object sender, EventArgs e)
        {

        }

        private void ExitWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser(connDB);
            formUser.ShowDialog();
        }

        private void addressesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddress formAddress = new FormAddress(connDB);
            formAddress.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seeAllPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPayments formPayments = new FormPayments(connDB);
            formPayments.ShowDialog();
        }

        private void addAPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSinglePayment formAddSinglePayment = new FormAddSinglePayment(connDB);
            formAddSinglePayment.ShowDialog();
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendors formVendors = new FormVendors(connDB);
            formVendors.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts(connDB);
            formProducts.ShowDialog();
        }

        private void billsRecievedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBills formBills = new FormBills(connDB);
            formBills.ShowDialog();
        }

        private void databaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettingsDatabase formSettingsDatabase = new FormSettingsDatabase(connDB);
            formSettingsDatabase.ShowDialog();
            connDB = formSettingsDatabase.ConnDB;
        }
    }
}
