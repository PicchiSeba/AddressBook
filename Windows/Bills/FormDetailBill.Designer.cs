
namespace AddressBook.Windows.Bills
{
    partial class FormDetailBill
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
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAddDetailBill = new System.Windows.Forms.Button();
            this.buttonEditDetailBill = new System.Windows.Forms.Button();
            this.buttonDeleteDetailBill = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonProductPageDetailBill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.groupBoxActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonProductPageDetailBill);
            this.groupBoxActions.Controls.Add(this.comboBox1);
            this.groupBoxActions.Controls.Add(this.textBox1);
            this.groupBoxActions.Controls.Add(this.buttonDeleteDetailBill);
            this.groupBoxActions.Controls.Add(this.buttonEditDetailBill);
            this.groupBoxActions.Controls.Add(this.buttonAddDetailBill);
            this.groupBoxActions.Controls.Add(this.buttonReturn);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxActions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(800, 149);
            this.groupBoxActions.TabIndex = 0;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 301);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // buttonAddDetailBill
            // 
            this.buttonAddDetailBill.BackColor = System.Drawing.Color.Lime;
            this.buttonAddDetailBill.Location = new System.Drawing.Point(12, 62);
            this.buttonAddDetailBill.Name = "buttonAddDetailBill";
            this.buttonAddDetailBill.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDetailBill.TabIndex = 1;
            this.buttonAddDetailBill.Text = "Add";
            this.buttonAddDetailBill.UseVisualStyleBackColor = false;
            // 
            // buttonEditDetailBill
            // 
            this.buttonEditDetailBill.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEditDetailBill.Location = new System.Drawing.Point(93, 62);
            this.buttonEditDetailBill.Name = "buttonEditDetailBill";
            this.buttonEditDetailBill.Size = new System.Drawing.Size(75, 23);
            this.buttonEditDetailBill.TabIndex = 3;
            this.buttonEditDetailBill.Text = "Edit";
            this.buttonEditDetailBill.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteDetailBill
            // 
            this.buttonDeleteDetailBill.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDeleteDetailBill.Location = new System.Drawing.Point(174, 62);
            this.buttonDeleteDetailBill.Name = "buttonDeleteDetailBill";
            this.buttonDeleteDetailBill.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDetailBill.TabIndex = 5;
            this.buttonDeleteDetailBill.Text = "Delete";
            this.buttonDeleteDetailBill.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(391, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // buttonProductPageDetailBill
            // 
            this.buttonProductPageDetailBill.Location = new System.Drawing.Point(528, 64);
            this.buttonProductPageDetailBill.Name = "buttonProductPageDetailBill";
            this.buttonProductPageDetailBill.Size = new System.Drawing.Size(75, 23);
            this.buttonProductPageDetailBill.TabIndex = 8;
            this.buttonProductPageDetailBill.Text = "Products page";
            this.buttonProductPageDetailBill.UseVisualStyleBackColor = true;
            // 
            // FormDetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormDetailBill";
            this.Text = "FormDetailBill";
            this.panel1.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonDeleteDetailBill;
        private System.Windows.Forms.Button buttonEditDetailBill;
        private System.Windows.Forms.Button buttonAddDetailBill;
        private System.Windows.Forms.Button buttonProductPageDetailBill;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}