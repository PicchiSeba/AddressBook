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

        public FormPayments(DBConnection connDB)
        {
            this.connDB = connDB;
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

            int index = 0;
            foreach (INote singleNote in allNotes)
            {
                ListViewItem item = new ListViewItem();
                item.UseItemStyleForSubItems = false;
                item.ForeColor = Color.FromName("Windows Text");
                item.Text = singleNote.ID.ToString();
                item.SubItems.Add(singleNote.User.ToString());
                item.SubItems.Add(singleNote.Description);
                item.SubItems.Add(singleNote.Debt.ToString());
                item.SubItems.Add(singleNote.Profit.ToString());
                float total = Convert.ToSingle(item.SubItems[4].Text) - Convert.ToSingle(item.SubItems[3].Text);
                if (index != 0)
                {
                    total += Convert.ToSingle(listViewNotes.Items[index - 1].SubItems[5].Text);
                }
                item.SubItems.Add(total.ToString());
                if (total > 0) item.SubItems[5].ForeColor = Color.FromName("Lime");
                else if (total < 0) item.SubItems[5].ForeColor = Color.FromName("Red");
                else item.SubItems[5].ForeColor = Color.FromName("Windows Text");
                listViewNotes.Items.Add(item);
                index++;
            }

            listViewNotes.Refresh();
        }

        private bool ValidateData(string description, string debt, string profit)
        {
            if (string.IsNullOrEmpty(description) ||
                description.Length > 1024)
                return false;
            try
            {
                Convert.ToSingle(debt);
            }
            catch
            {
                return false;
            }

            try
            {
                Convert.ToSingle(profit);
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void ResetPanelActions()
        {
            comboBoxUser.SelectedIndex = -1;
            comboBoxUser.Text = "";
            textBoxID.Text = "";
            textBoxDebt.Text = "";
            textBoxProfit.Text = "";
            richTextBoxDescription.Text = "";
            buttonEdit.Enabled = false;
            buttonEdit.BackColor = Color.FromName("MenuBar");
            buttonDelete.Enabled = false;
            buttonDelete.BackColor = Color.FromName("MenuBar");
            panelActions.Refresh();
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
            listViewNotes.Items.Clear();
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            connDB.DeleteNote(int.Parse(textBoxID.Text));
            ResetPanelActions();
            listViewNotes.Items.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ValidateData(richTextBoxDescription.Text, textBoxDebt.Text, textBoxProfit.Text))
            {
                connDB.UpdateNote(
                    new BaseNote(
                        int.Parse(textBoxID.Text),
                        users[comboBoxUser.SelectedIndex],
                        richTextBoxDescription.Text,
                        Convert.ToSingle(textBoxDebt.Text),
                        Convert.ToSingle(textBoxProfit.Text)
                        )
                    );
                ResetPanelActions();
            }
            listViewNotes.Items.Clear();
        }
    }
}
