
namespace AddressBook.Windows.DeleteConfirmation
{
    partial class FormDeleteConfirmation
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
            this.labelDeleteConfirmation = new System.Windows.Forms.Label();
            this.buttonYES = new System.Windows.Forms.Button();
            this.buttonNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeleteConfirmation
            // 
            this.labelDeleteConfirmation.AutoSize = true;
            this.labelDeleteConfirmation.Location = new System.Drawing.Point(12, 9);
            this.labelDeleteConfirmation.Name = "labelDeleteConfirmation";
            this.labelDeleteConfirmation.Size = new System.Drawing.Size(118, 13);
            this.labelDeleteConfirmation.TabIndex = 0;
            this.labelDeleteConfirmation.Text = "labelDeleteConfirmation";
            this.labelDeleteConfirmation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonYES
            // 
            this.buttonYES.Location = new System.Drawing.Point(58, 90);
            this.buttonYES.Name = "buttonYES";
            this.buttonYES.Size = new System.Drawing.Size(75, 23);
            this.buttonYES.TabIndex = 1;
            this.buttonYES.Text = "YES";
            this.buttonYES.UseVisualStyleBackColor = true;
            this.buttonYES.Click += new System.EventHandler(this.buttonYES_Click);
            // 
            // buttonNO
            // 
            this.buttonNO.Location = new System.Drawing.Point(188, 90);
            this.buttonNO.Name = "buttonNO";
            this.buttonNO.Size = new System.Drawing.Size(75, 23);
            this.buttonNO.TabIndex = 2;
            this.buttonNO.Text = "NO";
            this.buttonNO.UseVisualStyleBackColor = true;
            this.buttonNO.Click += new System.EventHandler(this.buttonNO_Click);
            // 
            // FormDeleteConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(321, 125);
            this.Controls.Add(this.buttonNO);
            this.Controls.Add(this.buttonYES);
            this.Controls.Add(this.labelDeleteConfirmation);
            this.Name = "FormDeleteConfirmation";
            this.Text = "Confirm deletion";
            this.Load += new System.EventHandler(this.FormDeleteConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteConfirmation;
        private System.Windows.Forms.Button buttonYES;
        private System.Windows.Forms.Button buttonNO;
    }
}