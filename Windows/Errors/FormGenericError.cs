using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.Windows.Errors
{
    public partial class FormGenericError : Form
    {
        public FormGenericError(string error)
        {
            InitializeComponent();
            labelGenericError.Text = "ERROR\n" + error;
        }

        private void FormGenericError_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
