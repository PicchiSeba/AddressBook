using AddressBook.DB;
using AddressBook.Model;
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
        private DBConnection connDB;
        private List<IContact> users;
        private int currentlySelected = -1;

        public FormPayments()
        {
            connDB = new DBConnection();
            InitializeComponent();
            LoadUsers();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadUsers()
        {
            users = connDB.SelectAllContacts();
            foreach(IContact singleUser in users)
            {
                comboBoxUser.Items.Add(singleUser.ToString());
            }
        }

        private void LoadNotes(int id_user)
        {
            List<INote> allNotes = connDB.SelectPaymentsByUserID(id_user);
            listViewNotes.Items.Clear();

            foreach (INote singleNote in allNotes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = singleNote.ID.ToString();
                item.SubItems.Add(singleNote.User.ToString());
                item.SubItems.Add(singleNote.Description);
                item.SubItems.Add(singleNote.Debt.ToString());
                item.SubItems.Add(singleNote.Profit.ToString());

                listViewNotes.Items.Add(item);
            }

            listViewNotes.Refresh();
        }

        private bool ValidateData(int id_user, string description, float debt, float profit)
        {
            if (string.IsNullOrEmpty(description) ||
                description.Length > 1024)
                return false;
            return true;
        }

        private void ResetPanelActions()
        {
            buttonEdit.Enabled = false;
            buttonEdit.BackColor = Color.FromName("MenuBar");
            buttonDelete.Enabled = false;
            buttonDelete.BackColor = Color.FromName("MenuBar");
        }

        private void EnablePanelActions()
        {
            buttonEdit.Enabled = true;
            buttonEdit.BackColor = Color.FromName("Gold");
            buttonDelete.Enabled = true;
            buttonDelete.BackColor = Color.FromName("Red");
        }

        private void listViewPayments_Click(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count > 0)
            {
                EnablePanelActions();

                textBoxID.Text = listViewNotes.SelectedItems[0].Text;
                comboBoxUser.Text = listViewNotes.SelectedItems[0].SubItems[1].Text;
                richTextBoxDescription.Text = listViewNotes.SelectedItems[0].SubItems[2].Text;
                textBoxDebt.Text = listViewNotes.SelectedItems[0].SubItems[3].Text;
                textBoxProfit.Text = listViewNotes.SelectedItems[0].SubItems[4].Text;

                panelActions.Refresh();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetPanelActions();
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxUser.SelectedItem != null)
            {
                if (currentlySelected == -1 || currentlySelected != comboBoxUser.SelectedIndex)
                {
                    currentlySelected = comboBoxUser.SelectedIndex;
                    LoadNotes(comboBoxUser.SelectedIndex + 1);
                    listViewNotes.Refresh();
                }
            }
        }
    }
}
