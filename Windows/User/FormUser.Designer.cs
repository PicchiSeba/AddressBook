
namespace AddressBook
{
    partial class FormUser
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
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAdditionalData = new System.Windows.Forms.Button();
            this.comboBoxAddresses = new System.Windows.Forms.ComboBox();
            this.labelKeyword = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonSearchField = new System.Windows.Forms.Button();
            this.buttonDeleteContact = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonEditContact = new System.Windows.Forms.Button();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonReturn);
            this.groupBoxActions.Controls.Add(this.buttonAdditionalData);
            this.groupBoxActions.Controls.Add(this.comboBoxAddresses);
            this.groupBoxActions.Controls.Add(this.labelKeyword);
            this.groupBoxActions.Controls.Add(this.labelPhoneNumber);
            this.groupBoxActions.Controls.Add(this.labelAddress);
            this.groupBoxActions.Controls.Add(this.labelName);
            this.groupBoxActions.Controls.Add(this.buttonResetSearch);
            this.groupBoxActions.Controls.Add(this.textBoxID);
            this.groupBoxActions.Controls.Add(this.buttonSearchField);
            this.groupBoxActions.Controls.Add(this.buttonDeleteContact);
            this.groupBoxActions.Controls.Add(this.textBoxSearch);
            this.groupBoxActions.Controls.Add(this.buttonEditContact);
            this.groupBoxActions.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxActions.Controls.Add(this.textBoxName);
            this.groupBoxActions.Controls.Add(this.buttonAddContact);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxActions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(657, 144);
            this.groupBoxActions.TabIndex = 0;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(9, 19);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 13;
            this.buttonReturn.Text = "<--- Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAdditionalData
            // 
            this.buttonAdditionalData.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonAdditionalData.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdditionalData.Location = new System.Drawing.Point(324, 64);
            this.buttonAdditionalData.Name = "buttonAdditionalData";
            this.buttonAdditionalData.Size = new System.Drawing.Size(96, 22);
            this.buttonAdditionalData.TabIndex = 12;
            this.buttonAdditionalData.Text = "Additional data";
            this.buttonAdditionalData.UseVisualStyleBackColor = false;
            this.buttonAdditionalData.Click += new System.EventHandler(this.buttonAdditionalData_Click);
            // 
            // comboBoxAddresses
            // 
            this.comboBoxAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddresses.FormattingEnabled = true;
            this.comboBoxAddresses.Location = new System.Drawing.Point(115, 115);
            this.comboBoxAddresses.Name = "comboBoxAddresses";
            this.comboBoxAddresses.Size = new System.Drawing.Size(203, 21);
            this.comboBoxAddresses.TabIndex = 11;
            // 
            // labelKeyword
            // 
            this.labelKeyword.AutoSize = true;
            this.labelKeyword.Location = new System.Drawing.Point(479, 99);
            this.labelKeyword.Name = "labelKeyword";
            this.labelKeyword.Size = new System.Drawing.Size(48, 13);
            this.labelKeyword.TabIndex = 10;
            this.labelKeyword.Text = "Keyword";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(321, 99);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.labelPhoneNumber.TabIndex = 9;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(112, 99);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 99);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.BackColor = System.Drawing.Color.Snow;
            this.buttonResetSearch.Location = new System.Drawing.Point(538, 65);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(75, 21);
            this.buttonResetSearch.TabIndex = 2;
            this.buttonResetSearch.Text = "Reset";
            this.buttonResetSearch.UseVisualStyleBackColor = false;
            this.buttonResetSearch.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(250, 65);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(68, 20);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.Text = "ID";
            // 
            // buttonSearchField
            // 
            this.buttonSearchField.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSearchField.Location = new System.Drawing.Point(457, 65);
            this.buttonSearchField.Name = "buttonSearchField";
            this.buttonSearchField.Size = new System.Drawing.Size(75, 21);
            this.buttonSearchField.TabIndex = 1;
            this.buttonSearchField.Text = "Search";
            this.buttonSearchField.UseVisualStyleBackColor = false;
            this.buttonSearchField.Click += new System.EventHandler(this.buttonSearchField_Click);
            // 
            // buttonDeleteContact
            // 
            this.buttonDeleteContact.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDeleteContact.Enabled = false;
            this.buttonDeleteContact.Location = new System.Drawing.Point(168, 64);
            this.buttonDeleteContact.Name = "buttonDeleteContact";
            this.buttonDeleteContact.Size = new System.Drawing.Size(75, 22);
            this.buttonDeleteContact.TabIndex = 2;
            this.buttonDeleteContact.Text = "Delete";
            this.buttonDeleteContact.UseVisualStyleBackColor = false;
            this.buttonDeleteContact.Click += new System.EventHandler(this.buttonDeleteContact_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(482, 115);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // buttonEditContact
            // 
            this.buttonEditContact.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEditContact.Enabled = false;
            this.buttonEditContact.Location = new System.Drawing.Point(87, 64);
            this.buttonEditContact.Name = "buttonEditContact";
            this.buttonEditContact.Size = new System.Drawing.Size(75, 22);
            this.buttonEditContact.TabIndex = 1;
            this.buttonEditContact.Text = "Edit";
            this.buttonEditContact.UseVisualStyleBackColor = false;
            this.buttonEditContact.Click += new System.EventHandler(this.buttonEditContact_Click);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(324, 115);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 116);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.BackColor = System.Drawing.Color.Lime;
            this.buttonAddContact.Location = new System.Drawing.Point(6, 64);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(75, 22);
            this.buttonAddContact.TabIndex = 0;
            this.buttonAddContact.Text = "Add";
            this.buttonAddContact.UseVisualStyleBackColor = false;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // listViewMain
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnAddress,
            this.columnPhoneNumber});
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(0, 144);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewMain";
            this.listViewUsers.Size = new System.Drawing.Size(657, 334);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.Click += new System.EventHandler(this.listViewMain_Click);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            // 
            // columnPhoneNumber
            // 
            this.columnPhoneNumber.Text = "Phone number";
            this.columnPhoneNumber.Width = 86;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 478);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.groupBoxActions);
            this.Name = "FormUser";
            this.Text = "Users management";
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Button buttonDeleteContact;
        private System.Windows.Forms.Button buttonEditContact;
        private System.Windows.Forms.Button buttonResetSearch;
        private System.Windows.Forms.Button buttonSearchField;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnPhoneNumber;
        private System.Windows.Forms.Label labelKeyword;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxAddresses;
        private System.Windows.Forms.Button buttonAdditionalData;
        private System.Windows.Forms.Button buttonReturn;
    }
}

