
namespace AddressBook.Windows.Vendors
{
    partial class FormVendors
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
            this.panelActions = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewVendors = new System.Windows.Forms.ListView();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostalCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProvince = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMobilePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWebsite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxMobilePhone = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhoneNunber = new System.Windows.Forms.Label();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panelActions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.groupBoxActions);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(800, 139);
            this.panelActions.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewVendors);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 311);
            this.panel2.TabIndex = 1;
            // 
            // listViewVendors
            // 
            this.listViewVendors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderStreet,
            this.columnHeaderCity,
            this.columnHeaderPostalCode,
            this.columnHeaderProvince,
            this.columnHeaderPhoneNumber,
            this.columnHeaderMobilePhone,
            this.columnHeaderWebsite});
            this.listViewVendors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVendors.HideSelection = false;
            this.listViewVendors.Location = new System.Drawing.Point(0, 0);
            this.listViewVendors.Name = "listViewVendors";
            this.listViewVendors.Size = new System.Drawing.Size(800, 311);
            this.listViewVendors.TabIndex = 0;
            this.listViewVendors.UseCompatibleStateImageBehavior = false;
            this.listViewVendors.View = System.Windows.Forms.View.Details;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(6, 19);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "<--- Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Location = new System.Drawing.Point(5, 58);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEdit.Location = new System.Drawing.Point(86, 58);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDelete.Location = new System.Drawing.Point(167, 58);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderStreet
            // 
            this.columnHeaderStreet.Text = "Street";
            // 
            // columnHeaderPostalCode
            // 
            this.columnHeaderPostalCode.Text = "Postal code";
            // 
            // columnHeaderProvince
            // 
            this.columnHeaderProvince.Text = "Province";
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "Phone number";
            // 
            // columnHeaderMobilePhone
            // 
            this.columnHeaderMobilePhone.Text = "Mobile phone";
            // 
            // columnHeaderWebsite
            // 
            this.columnHeaderWebsite.Text = "Website";
            // 
            // columnHeaderCity
            // 
            this.columnHeaderCity.Text = "City";
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(111, 107);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddress.TabIndex = 5;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(238, 107);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 6;
            // 
            // textBoxMobilePhone
            // 
            this.textBoxMobilePhone.Location = new System.Drawing.Point(344, 107);
            this.textBoxMobilePhone.Name = "textBoxMobilePhone";
            this.textBoxMobilePhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxMobilePhone.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 94);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(108, 94);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address";
            // 
            // labelPhoneNunber
            // 
            this.labelPhoneNunber.AutoSize = true;
            this.labelPhoneNunber.Location = new System.Drawing.Point(235, 94);
            this.labelPhoneNunber.Name = "labelPhoneNunber";
            this.labelPhoneNunber.Size = new System.Drawing.Size(74, 13);
            this.labelPhoneNunber.TabIndex = 10;
            this.labelPhoneNunber.Text = "Phone nunber";
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Location = new System.Drawing.Point(341, 94);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(71, 13);
            this.labelMobilePhone.TabIndex = 11;
            this.labelMobilePhone.Text = "Mobile phone";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(5, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Location = new System.Drawing.Point(451, 107);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(100, 20);
            this.textBoxWebsite.TabIndex = 13;
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(450, 94);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(46, 13);
            this.labelWebsite.TabIndex = 14;
            this.labelWebsite.Text = "Website";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonReset);
            this.groupBoxActions.Controls.Add(this.buttonReturn);
            this.groupBoxActions.Controls.Add(this.labelWebsite);
            this.groupBoxActions.Controls.Add(this.buttonAdd);
            this.groupBoxActions.Controls.Add(this.textBoxWebsite);
            this.groupBoxActions.Controls.Add(this.buttonEdit);
            this.groupBoxActions.Controls.Add(this.textBoxName);
            this.groupBoxActions.Controls.Add(this.buttonDelete);
            this.groupBoxActions.Controls.Add(this.labelMobilePhone);
            this.groupBoxActions.Controls.Add(this.comboBoxAddress);
            this.groupBoxActions.Controls.Add(this.labelPhoneNunber);
            this.groupBoxActions.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxActions.Controls.Add(this.labelAddress);
            this.groupBoxActions.Controls.Add(this.textBoxMobilePhone);
            this.groupBoxActions.Controls.Add(this.labelName);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(800, 139);
            this.groupBoxActions.TabIndex = 15;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(406, 58);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // FormVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelActions);
            this.Name = "FormVendors";
            this.Text = "FormVendors";
            this.panelActions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ListView listViewVendors;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderStreet;
        private System.Windows.Forms.ColumnHeader columnHeaderCity;
        private System.Windows.Forms.ColumnHeader columnHeaderPostalCode;
        private System.Windows.Forms.ColumnHeader columnHeaderProvince;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderMobilePhone;
        private System.Windows.Forms.ColumnHeader columnHeaderWebsite;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMobilePhone;
        private System.Windows.Forms.Label labelPhoneNunber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxMobilePhone;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonReset;
    }
}