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
    public partial class FormDetailBill : Form
    {
        DBConnection connDB = new DBConnection();
        List<IBillDetail> allDetailBills = new List<IBillDetail>();

        public FormDetailBill()
        {
            InitializeComponent();
            LoadQueries();
        }

        private void LoadQueries()
        {
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
