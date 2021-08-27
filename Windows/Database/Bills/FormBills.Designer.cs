
namespace AddressBook.Windows.Bills
{
    partial class FormBills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewBillMasters = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBillNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVendor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaymentMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonDetailsBill = new System.Windows.Forms.Button();
            this.textBoxIDBill = new System.Windows.Forms.TextBox();
            this.textBoxPaymentMethodBill = new System.Windows.Forms.TextBox();
            this.labelPaymentMethodBill = new System.Windows.Forms.Label();
            this.labelVendorBill = new System.Windows.Forms.Label();
            this.labelDateBill = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.comboBoxVendors = new System.Windows.Forms.ComboBox();
            this.labelNumberBill = new System.Windows.Forms.Label();
            this.textBoxBillNumber = new System.Windows.Forms.TextBox();
            this.buttonDeleteBill = new System.Windows.Forms.Button();
            this.buttonEditBill = new System.Windows.Forms.Button();
            this.buttonAddBill = new System.Windows.Forms.Button();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonExportPDF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewBillMasters);
            this.panel1.Controls.Add(this.groupBoxActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // listViewBillMasters
            // 
            this.listViewBillMasters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderBillNumber,
            this.columnHeaderDate,
            this.columnHeaderVendor,
            this.columnHeaderTotalPrice,
            this.columnHeaderPaid,
            this.columnHeaderPaymentMethod});
            this.listViewBillMasters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBillMasters.FullRowSelect = true;
            this.listViewBillMasters.GridLines = true;
            this.listViewBillMasters.HideSelection = false;
            this.listViewBillMasters.Location = new System.Drawing.Point(0, 164);
            this.listViewBillMasters.MultiSelect = false;
            this.listViewBillMasters.Name = "listViewBillMasters";
            this.listViewBillMasters.Size = new System.Drawing.Size(800, 286);
            this.listViewBillMasters.TabIndex = 1;
            this.listViewBillMasters.UseCompatibleStateImageBehavior = false;
            this.listViewBillMasters.View = System.Windows.Forms.View.Details;
            this.listViewBillMasters.SelectedIndexChanged += new System.EventHandler(this.listViewBillMasters_Click);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderBillNumber
            // 
            this.columnHeaderBillNumber.Text = "Bill number";
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            // 
            // columnHeaderVendor
            // 
            this.columnHeaderVendor.Text = "Vendor";
            // 
            // columnHeaderTotalPrice
            // 
            this.columnHeaderTotalPrice.Text = "Total price";
            // 
            // columnHeaderPaid
            // 
            this.columnHeaderPaid.Text = "Paid?";
            // 
            // columnHeaderPaymentMethod
            // 
            this.columnHeaderPaymentMethod.Text = "Payment method";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonExportPDF);
            this.groupBoxActions.Controls.Add(this.buttonDetailsBill);
            this.groupBoxActions.Controls.Add(this.textBoxIDBill);
            this.groupBoxActions.Controls.Add(this.textBoxPaymentMethodBill);
            this.groupBoxActions.Controls.Add(this.labelPaymentMethodBill);
            this.groupBoxActions.Controls.Add(this.labelVendorBill);
            this.groupBoxActions.Controls.Add(this.labelDateBill);
            this.groupBoxActions.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBoxActions.Controls.Add(this.comboBoxVendors);
            this.groupBoxActions.Controls.Add(this.labelNumberBill);
            this.groupBoxActions.Controls.Add(this.textBoxBillNumber);
            this.groupBoxActions.Controls.Add(this.buttonDeleteBill);
            this.groupBoxActions.Controls.Add(this.buttonEditBill);
            this.groupBoxActions.Controls.Add(this.buttonAddBill);
            this.groupBoxActions.Controls.Add(this.checkBoxPaid);
            this.groupBoxActions.Controls.Add(this.dateTimePicker1);
            this.groupBoxActions.Controls.Add(this.buttonReturn);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxActions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(800, 164);
            this.groupBoxActions.TabIndex = 0;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonDetailsBill
            // 
            this.buttonDetailsBill.Enabled = false;
            this.buttonDetailsBill.Location = new System.Drawing.Point(459, 67);
            this.buttonDetailsBill.Name = "buttonDetailsBill";
            this.buttonDetailsBill.Size = new System.Drawing.Size(75, 23);
            this.buttonDetailsBill.TabIndex = 15;
            this.buttonDetailsBill.Text = "See details";
            this.buttonDetailsBill.UseVisualStyleBackColor = true;
            this.buttonDetailsBill.Click += new System.EventHandler(this.buttonDetailsBill_Click);
            // 
            // textBoxIDBill
            // 
            this.textBoxIDBill.Location = new System.Drawing.Point(281, 70);
            this.textBoxIDBill.Name = "textBoxIDBill";
            this.textBoxIDBill.ReadOnly = true;
            this.textBoxIDBill.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDBill.TabIndex = 14;
            this.textBoxIDBill.Text = "ID";
            // 
            // textBoxPaymentMethodBill
            // 
            this.textBoxPaymentMethodBill.Enabled = false;
            this.textBoxPaymentMethodBill.Location = new System.Drawing.Point(578, 119);
            this.textBoxPaymentMethodBill.Name = "textBoxPaymentMethodBill";
            this.textBoxPaymentMethodBill.Size = new System.Drawing.Size(100, 20);
            this.textBoxPaymentMethodBill.TabIndex = 13;
            // 
            // labelPaymentMethodBill
            // 
            this.labelPaymentMethodBill.AutoSize = true;
            this.labelPaymentMethodBill.Location = new System.Drawing.Point(448, 103);
            this.labelPaymentMethodBill.Name = "labelPaymentMethodBill";
            this.labelPaymentMethodBill.Size = new System.Drawing.Size(86, 13);
            this.labelPaymentMethodBill.TabIndex = 12;
            this.labelPaymentMethodBill.Text = "Payment method";
            // 
            // labelVendorBill
            // 
            this.labelVendorBill.AutoSize = true;
            this.labelVendorBill.Location = new System.Drawing.Point(325, 104);
            this.labelVendorBill.Name = "labelVendorBill";
            this.labelVendorBill.Size = new System.Drawing.Size(41, 13);
            this.labelVendorBill.TabIndex = 11;
            this.labelVendorBill.Text = "Vendor";
            // 
            // labelDateBill
            // 
            this.labelDateBill.AutoSize = true;
            this.labelDateBill.Location = new System.Drawing.Point(118, 104);
            this.labelDateBill.Name = "labelDateBill";
            this.labelDateBill.Size = new System.Drawing.Size(30, 13);
            this.labelDateBill.TabIndex = 10;
            this.labelDateBill.Text = "Date";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(451, 119);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPaymentMethod.TabIndex = 9;
            this.comboBoxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentMethod_SelectedIndexChanged);
            // 
            // comboBoxVendors
            // 
            this.comboBoxVendors.FormattingEnabled = true;
            this.comboBoxVendors.Location = new System.Drawing.Point(324, 119);
            this.comboBoxVendors.Name = "comboBoxVendors";
            this.comboBoxVendors.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVendors.TabIndex = 8;
            // 
            // labelNumberBill
            // 
            this.labelNumberBill.AutoSize = true;
            this.labelNumberBill.Location = new System.Drawing.Point(12, 104);
            this.labelNumberBill.Name = "labelNumberBill";
            this.labelNumberBill.Size = new System.Drawing.Size(58, 13);
            this.labelNumberBill.TabIndex = 7;
            this.labelNumberBill.Text = "Bill number";
            // 
            // textBoxBillNumber
            // 
            this.textBoxBillNumber.Location = new System.Drawing.Point(12, 120);
            this.textBoxBillNumber.Name = "textBoxBillNumber";
            this.textBoxBillNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxBillNumber.TabIndex = 6;
            // 
            // buttonDeleteBill
            // 
            this.buttonDeleteBill.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDeleteBill.Location = new System.Drawing.Point(174, 67);
            this.buttonDeleteBill.Name = "buttonDeleteBill";
            this.buttonDeleteBill.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteBill.TabIndex = 5;
            this.buttonDeleteBill.Text = "Delete";
            this.buttonDeleteBill.UseVisualStyleBackColor = false;
            this.buttonDeleteBill.Click += new System.EventHandler(this.buttonDeleteBill_Click);
            // 
            // buttonEditBill
            // 
            this.buttonEditBill.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEditBill.Location = new System.Drawing.Point(93, 67);
            this.buttonEditBill.Name = "buttonEditBill";
            this.buttonEditBill.Size = new System.Drawing.Size(75, 23);
            this.buttonEditBill.TabIndex = 4;
            this.buttonEditBill.Text = "Edit";
            this.buttonEditBill.UseVisualStyleBackColor = false;
            this.buttonEditBill.Click += new System.EventHandler(this.buttonEditBill_Click);
            // 
            // buttonAddBill
            // 
            this.buttonAddBill.BackColor = System.Drawing.Color.Lime;
            this.buttonAddBill.Location = new System.Drawing.Point(12, 67);
            this.buttonAddBill.Name = "buttonAddBill";
            this.buttonAddBill.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBill.TabIndex = 3;
            this.buttonAddBill.Text = "Add";
            this.buttonAddBill.UseVisualStyleBackColor = false;
            this.buttonAddBill.Click += new System.EventHandler(this.buttonAddBill_Click);
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Location = new System.Drawing.Point(398, 72);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(47, 17);
            this.checkBoxPaid.TabIndex = 2;
            this.checkBoxPaid.Text = "Paid";
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 120);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(12, 19);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "<--- Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.Location = new System.Drawing.Point(451, 19);
            this.buttonExportPDF.Name = "buttonExportPDF";
            this.buttonExportPDF.Size = new System.Drawing.Size(91, 23);
            this.buttonExportPDF.TabIndex = 16;
            this.buttonExportPDF.Text = "Export to PDF";
            this.buttonExportPDF.UseVisualStyleBackColor = true;
            this.buttonExportPDF.Click += new System.EventHandler(this.buttonExportPDF_Click);
            // 
            // FormBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormBills";
            this.Text = "FormBills";
            this.panel1.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewBillMasters;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderBillNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderVendor;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonDeleteBill;
        private System.Windows.Forms.Button buttonEditBill;
        private System.Windows.Forms.Button buttonAddBill;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderPaid;
        private System.Windows.Forms.ColumnHeader columnHeaderPaymentMethod;
        private System.Windows.Forms.TextBox textBoxBillNumber;
        private System.Windows.Forms.TextBox textBoxPaymentMethodBill;
        private System.Windows.Forms.Label labelPaymentMethodBill;
        private System.Windows.Forms.Label labelVendorBill;
        private System.Windows.Forms.Label labelDateBill;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.ComboBox comboBoxVendors;
        private System.Windows.Forms.Label labelNumberBill;
        private System.Windows.Forms.TextBox textBoxIDBill;
        private System.Windows.Forms.Button buttonDetailsBill;
        private System.Windows.Forms.Button buttonExportPDF;
    }
}