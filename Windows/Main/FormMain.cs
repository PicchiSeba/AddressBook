using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook.Windows.Address;
using AddressBook.Windows.Payments;

namespace AddressBook.Windows.Main
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.ShowDialog();
        }

        private void addressesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddress formAddress = new FormAddress();
            formAddress.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seeAllPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPayments formPayments = new FormPayments();
            formPayments.ShowDialog();
        }

        private void addAPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSinglePayment formAddSinglePayment = new FormAddSinglePayment();
            formAddSinglePayment.ShowDialog();
        }
    }
}
