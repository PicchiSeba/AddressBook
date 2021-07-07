using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Windows.Payments
{
    public partial class FormPayments : Form
    {
        public FormPayments()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetPanelActions()
        {
            buttonEdit.Enabled = false;
            buttonEdit.BackColor = Color.FromName("MenuBar");
            buttonDelete.Enabled = false;
            buttonDelete.BackColor = Color.FromName("MenuBar");
        }

        private void enablePanelActions()
        {
            buttonEdit.Enabled = true;
            buttonEdit.BackColor = Color.FromName("Gold");
            buttonDelete.Enabled = true;
            buttonDelete.BackColor = Color.FromName("Red");
        }

        private void listViewPayments_Click(object sender, EventArgs e)
        {
            if (listViewPayments.SelectedItems.Count > 0)
            {
                enablePanelActions();

                textBoxID.Text = listViewPayments.SelectedItems[0].SubItems[0].Text;
                comboBoxUser.Text = listViewPayments.SelectedItems[0].SubItems[1].Text;
                textBoxDebt.Text = listViewPayments.SelectedItems[0].SubItems[2].Text;
                textBoxProfit.Text = listViewPayments.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
