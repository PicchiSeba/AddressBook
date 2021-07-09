
namespace AddressBook.Windows.Payments
{
    partial class FormPayments
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
            this.listViewNotes = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDebt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProfit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelActions = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelDebit = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.textBoxProfit = new System.Windows.Forms.TextBox();
            this.textBoxDebt = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewNotes
            // 
            this.listViewNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnUser,
            this.columnDescription,
            this.columnDebt,
            this.columnProfit,
            this.columnTotal});
            this.listViewNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewNotes.FullRowSelect = true;
            this.listViewNotes.GridLines = true;
            this.listViewNotes.HideSelection = false;
            this.listViewNotes.Location = new System.Drawing.Point(0, 142);
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(800, 308);
            this.listViewNotes.TabIndex = 0;
            this.listViewNotes.UseCompatibleStateImageBehavior = false;
            this.listViewNotes.View = System.Windows.Forms.View.Details;
            this.listViewNotes.SelectedIndexChanged += new System.EventHandler(this.listViewPayments_Click);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnUser
            // 
            this.columnUser.Text = "User";
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            // 
            // columnDebt
            // 
            this.columnDebt.Text = "Debt";
            // 
            // columnProfit
            // 
            this.columnProfit.Text = "Profit";
            // 
            // columnTotal
            // 
            this.columnTotal.Text = "Total";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEdit.Location = new System.Drawing.Point(12, 45);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDelete.Location = new System.Drawing.Point(12, 74);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.labelID);
            this.panelActions.Controls.Add(this.textBoxID);
            this.panelActions.Controls.Add(this.buttonReset);
            this.panelActions.Controls.Add(this.labelProfit);
            this.panelActions.Controls.Add(this.labelDebit);
            this.panelActions.Controls.Add(this.labelUser);
            this.panelActions.Controls.Add(this.comboBoxUser);
            this.panelActions.Controls.Add(this.textBoxProfit);
            this.panelActions.Controls.Add(this.textBoxDebt);
            this.panelActions.Controls.Add(this.labelDescription);
            this.panelActions.Controls.Add(this.buttonReturn);
            this.panelActions.Controls.Add(this.richTextBoxDescription);
            this.panelActions.Controls.Add(this.buttonDelete);
            this.panelActions.Controls.Add(this.buttonEdit);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(800, 136);
            this.panelActions.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(131, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(134, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(40, 20);
            this.textBoxID.TabIndex = 14;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(13, 104);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Location = new System.Drawing.Point(237, 88);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(31, 13);
            this.labelProfit.TabIndex = 12;
            this.labelProfit.Text = "Profit";
            // 
            // labelDebit
            // 
            this.labelDebit.AutoSize = true;
            this.labelDebit.Location = new System.Drawing.Point(131, 88);
            this.labelDebit.Name = "labelDebit";
            this.labelDebit.Size = new System.Drawing.Size(30, 13);
            this.labelDebit.TabIndex = 11;
            this.labelDebit.Text = "Debt";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(189, 8);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "User";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(192, 24);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(232, 21);
            this.comboBoxUser.TabIndex = 8;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // textBoxProfit
            // 
            this.textBoxProfit.Location = new System.Drawing.Point(240, 104);
            this.textBoxProfit.Name = "textBoxProfit";
            this.textBoxProfit.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfit.TabIndex = 7;
            // 
            // textBoxDebt
            // 
            this.textBoxDebt.Location = new System.Drawing.Point(134, 104);
            this.textBoxDebt.Name = "textBoxDebt";
            this.textBoxDebt.Size = new System.Drawing.Size(100, 20);
            this.textBoxDebt.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(427, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(168, 13);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description    ( max. length: 1024 )";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(12, 13);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "<--- Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(430, 25);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(358, 108);
            this.richTextBoxDescription.TabIndex = 3;
            this.richTextBoxDescription.Text = "";
            // 
            // FormPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.listViewNotes);
            this.Name = "FormPayments";
            this.Text = "FormPayments";
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewNotes;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnUser;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnDebt;
        private System.Windows.Forms.ColumnHeader columnProfit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.TextBox textBoxProfit;
        private System.Windows.Forms.TextBox textBoxDebt;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.Label labelDebit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ColumnHeader columnTotal;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
    }
}