
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(6, 66);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(100, 20);
            this.textBoxStreet.TabIndex = 0;
            this.textBoxStreet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(112, 66);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(6, 50);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(35, 13);
            this.labelStreet.TabIndex = 3;
            this.labelStreet.Text = "Street";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(109, 50);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Number";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(218, 66);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostalCode.TabIndex = 5;
            // 
            // textBoxMunicipality
            // 
            this.textBoxMunicipality.Location = new System.Drawing.Point(324, 66);
            this.textBoxMunicipality.Name = "textBoxMunicipality";
            this.textBoxMunicipality.Size = new System.Drawing.Size(100, 20);
            this.textBoxMunicipality.TabIndex = 6;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(430, 66);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(100, 20);
            this.textBoxProvince.TabIndex = 7;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(215, 50);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(63, 13);
            this.labelPostalCode.TabIndex = 8;
            this.labelPostalCode.Text = "Postal code";
            // 
            // labelMunicipality
            // 
            this.labelMunicipality.AutoSize = true;
            this.labelMunicipality.Location = new System.Drawing.Point(318, 50);
            this.labelMunicipality.Name = "labelMunicipality";
            this.labelMunicipality.Size = new System.Drawing.Size(62, 13);
            this.labelMunicipality.TabIndex = 9;
            this.labelMunicipality.Text = "Municipality";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(427, 50);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(49, 13);
            this.labelProvince.TabIndex = 10;
            this.labelProvince.Text = "Province";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(533, 50);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 11;
            this.labelCountry.Text = "Country";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(536, 66);
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
            this.listViewAddresses.FullRowSelect = true;
            this.listViewAddresses.GridLines = true;
            this.listViewAddresses.HideSelection = false;
            this.listViewAddresses.Location = new System.Drawing.Point(16, 161);
            this.listViewAddresses.Name = "listViewAddresses";
            this.listViewAddresses.Size = new System.Drawing.Size(645, 295);
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
            this.buttonReturn.Location = new System.Drawing.Point(16, 12);
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
            this.buttonAdd.Location = new System.Drawing.Point(6, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 21);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Gold;
            this.buttonEdit.Location = new System.Drawing.Point(87, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 21);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(168, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 21);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(249, 20);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 18;
            this.textBoxID.Text = "ID";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonAdd);
            this.groupBoxActions.Controls.Add(this.textBoxID);
            this.groupBoxActions.Controls.Add(this.textBoxStreet);
            this.groupBoxActions.Controls.Add(this.labelCountry);
            this.groupBoxActions.Controls.Add(this.textBoxCountry);
            this.groupBoxActions.Controls.Add(this.buttonDelete);
            this.groupBoxActions.Controls.Add(this.labelStreet);
            this.groupBoxActions.Controls.Add(this.labelProvince);
            this.groupBoxActions.Controls.Add(this.buttonEdit);
            this.groupBoxActions.Controls.Add(this.textBoxProvince);
            this.groupBoxActions.Controls.Add(this.textBoxNumber);
            this.groupBoxActions.Controls.Add(this.textBoxPostalCode);
            this.groupBoxActions.Controls.Add(this.labelMunicipality);
            this.groupBoxActions.Controls.Add(this.labelPostalCode);
            this.groupBoxActions.Controls.Add(this.labelNumber);
            this.groupBoxActions.Controls.Add(this.textBoxMunicipality);
            this.groupBoxActions.Location = new System.Drawing.Point(16, 44);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(645, 103);
            this.groupBoxActions.TabIndex = 19;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // FormAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 475);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.listViewAddresses);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormAddress";
            this.Text = "FormAddress";
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
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
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnStreet;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnPostalCode;
        private System.Windows.Forms.ColumnHeader columnMunicipality;
        private System.Windows.Forms.ColumnHeader columnProvince;
        private System.Windows.Forms.ColumnHeader columnCountry;
        private System.Windows.Forms.GroupBox groupBoxActions;
    }
}