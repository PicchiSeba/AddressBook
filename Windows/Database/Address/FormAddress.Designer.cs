
namespace AddressBook.Windows.Address
{
    partial class FormAddress
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
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxMunicipality = new System.Windows.Forms.TextBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelMunicipality = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.listViewAddresses = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPostalCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMunicipality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProvince = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEditAddress = new System.Windows.Forms.Button();
            this.buttonDeleteAddress = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExportPDF = new System.Windows.Forms.Button();
            this.groupBoxActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(6, 109);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(100, 20);
            this.textBoxStreet.TabIndex = 0;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(112, 109);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(6, 93);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(35, 13);
            this.labelStreet.TabIndex = 3;
            this.labelStreet.Text = "Street";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(109, 93);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Number";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(218, 109);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostalCode.TabIndex = 5;
            // 
            // textBoxMunicipality
            // 
            this.textBoxMunicipality.Location = new System.Drawing.Point(324, 109);
            this.textBoxMunicipality.Name = "textBoxMunicipality";
            this.textBoxMunicipality.Size = new System.Drawing.Size(100, 20);
            this.textBoxMunicipality.TabIndex = 6;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(430, 109);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(100, 20);
            this.textBoxProvince.TabIndex = 7;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(215, 93);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(63, 13);
            this.labelPostalCode.TabIndex = 8;
            this.labelPostalCode.Text = "Postal code";
            // 
            // labelMunicipality
            // 
            this.labelMunicipality.AutoSize = true;
            this.labelMunicipality.Location = new System.Drawing.Point(318, 93);
            this.labelMunicipality.Name = "labelMunicipality";
            this.labelMunicipality.Size = new System.Drawing.Size(62, 13);
            this.labelMunicipality.TabIndex = 9;
            this.labelMunicipality.Text = "Municipality";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(427, 93);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(49, 13);
            this.labelProvince.TabIndex = 10;
            this.labelProvince.Text = "Province";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(533, 93);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 11;
            this.labelCountry.Text = "Country";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(536, 109);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountry.TabIndex = 12;
            // 
            // listViewAddresses
            // 
            this.listViewAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnStreet,
            this.columnNumber,
            this.columnPostalCode,
            this.columnMunicipality,
            this.columnProvince,
            this.columnCountry});
            this.listViewAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAddresses.FullRowSelect = true;
            this.listViewAddresses.GridLines = true;
            this.listViewAddresses.HideSelection = false;
            this.listViewAddresses.Location = new System.Drawing.Point(0, 0);
            this.listViewAddresses.Name = "listViewAddresses";
            this.listViewAddresses.Size = new System.Drawing.Size(733, 454);
            this.listViewAddresses.TabIndex = 13;
            this.listViewAddresses.UseCompatibleStateImageBehavior = false;
            this.listViewAddresses.View = System.Windows.Forms.View.Details;
            this.listViewAddresses.Click += new System.EventHandler(this.listViewAddresses_Click);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 48;
            // 
            // columnStreet
            // 
            this.columnStreet.Text = "Street";
            this.columnStreet.Width = 106;
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "Number";
            this.columnNumber.Width = 72;
            // 
            // columnPostalCode
            // 
            this.columnPostalCode.Text = "PostalCode";
            this.columnPostalCode.Width = 101;
            // 
            // columnMunicipality
            // 
            this.columnMunicipality.Text = "Municipality";
            this.columnMunicipality.Width = 84;
            // 
            // columnProvince
            // 
            this.columnProvince.Text = "Province";
            // 
            // columnCountry
            // 
            this.columnCountry.Text = "Country";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturn.Location = new System.Drawing.Point(9, 19);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 14;
            this.buttonReturn.Text = "<--- Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Location = new System.Drawing.Point(6, 62);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 21);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEditAddress
            // 
            this.buttonEditAddress.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEditAddress.Location = new System.Drawing.Point(87, 62);
            this.buttonEditAddress.Name = "buttonEditAddress";
            this.buttonEditAddress.Size = new System.Drawing.Size(75, 21);
            this.buttonEditAddress.TabIndex = 16;
            this.buttonEditAddress.Text = "Edit";
            this.buttonEditAddress.UseVisualStyleBackColor = false;
            this.buttonEditAddress.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDeleteAddress
            // 
            this.buttonDeleteAddress.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDeleteAddress.Location = new System.Drawing.Point(168, 62);
            this.buttonDeleteAddress.Name = "buttonDeleteAddress";
            this.buttonDeleteAddress.Size = new System.Drawing.Size(75, 21);
            this.buttonDeleteAddress.TabIndex = 17;
            this.buttonDeleteAddress.Text = "Delete";
            this.buttonDeleteAddress.UseVisualStyleBackColor = false;
            this.buttonDeleteAddress.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(249, 63);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 18;
            this.textBoxID.Text = "ID";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonExportPDF);
            this.groupBoxActions.Controls.Add(this.buttonReset);
            this.groupBoxActions.Controls.Add(this.buttonReturn);
            this.groupBoxActions.Controls.Add(this.buttonAdd);
            this.groupBoxActions.Controls.Add(this.textBoxID);
            this.groupBoxActions.Controls.Add(this.textBoxStreet);
            this.groupBoxActions.Controls.Add(this.labelCountry);
            this.groupBoxActions.Controls.Add(this.textBoxCountry);
            this.groupBoxActions.Controls.Add(this.buttonDeleteAddress);
            this.groupBoxActions.Controls.Add(this.labelStreet);
            this.groupBoxActions.Controls.Add(this.labelProvince);
            this.groupBoxActions.Controls.Add(this.buttonEditAddress);
            this.groupBoxActions.Controls.Add(this.textBoxProvince);
            this.groupBoxActions.Controls.Add(this.textBoxNumber);
            this.groupBoxActions.Controls.Add(this.textBoxPostalCode);
            this.groupBoxActions.Controls.Add(this.labelMunicipality);
            this.groupBoxActions.Controls.Add(this.labelPostalCode);
            this.groupBoxActions.Controls.Add(this.labelNumber);
            this.groupBoxActions.Controls.Add(this.textBoxMunicipality);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxActions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(733, 139);
            this.groupBoxActions.TabIndex = 19;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(454, 59);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBoxActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 593);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewAddresses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 454);
            this.panel2.TabIndex = 20;
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.Location = new System.Drawing.Point(430, 19);
            this.buttonExportPDF.Name = "buttonExportPDF";
            this.buttonExportPDF.Size = new System.Drawing.Size(121, 23);
            this.buttonExportPDF.TabIndex = 20;
            this.buttonExportPDF.Text = "Export to PDF";
            this.buttonExportPDF.UseVisualStyleBackColor = true;
            this.buttonExportPDF.Click += new System.EventHandler(this.buttonExportPDF_Click);
            // 
            // FormAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 593);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormAddress";
            this.Text = "Addresses management";
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxMunicipality;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelMunicipality;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.ListView listViewAddresses;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEditAddress;
        private System.Windows.Forms.Button buttonDeleteAddress;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnStreet;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnPostalCode;
        private System.Windows.Forms.ColumnHeader columnMunicipality;
        private System.Windows.Forms.ColumnHeader columnProvince;
        private System.Windows.Forms.ColumnHeader columnCountry;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExportPDF;
    }
}