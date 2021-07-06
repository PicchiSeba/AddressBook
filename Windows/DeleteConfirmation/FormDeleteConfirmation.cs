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

namespace AddressBook.Windows.DeleteConfirmation
{
    public partial class FormDeleteConfirmation : Form
    {
        private bool decisionSelected = false;
        private bool delete = false;

        public FormDeleteConfirmation(IContact contactData)
        {
            InitializeComponent();
            labelDeleteConfirmation.Text =
                "Are you sure you want to PERMANENTLY delete" +
                "\nthe following entry from the database" +
                "\n[" + contactData.ID + "]: " +
                contactData.Name + ", " +
                contactData.Address + ", " +
                contactData.PhoneNumber + "\n\t?";
            this.Focus();
            this.Refresh();
        }

        private void FormDeleteConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void buttonYES_Click(object sender, EventArgs e)
        {
            decisionSelected = true;
            delete = true;
            this.Refresh();
        }

        private void buttonNO_Click(object sender, EventArgs e)
        {
            decisionSelected = true;
            this.Refresh();
        }

        public bool OperationSelected
        {
            get
            {
                return decisionSelected;
            }
        }

        public bool Delete
        {
            get
            {
                return delete;
            }
        }
    }
}
