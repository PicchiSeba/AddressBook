
namespace AddressBook.Windows.Errors
{
    partial class FormGenericError
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
            this.labelGenericError = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGenericError
            // 
            this.labelGenericError.AutoSize = true;
            this.labelGenericError.Location = new System.Drawing.Point(12, 9);
            this.labelGenericError.Name = "labelGenericError";
            this.labelGenericError.Size = new System.Drawing.Size(88, 13);
            this.labelGenericError.TabIndex = 0;
            this.labelGenericError.Text = "labelGenericError";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(136, 72);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "Understood";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormGenericError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 107);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelGenericError);
            this.Name = "FormGenericError";
            this.Text = "FormGenericError";
            this.Load += new System.EventHandler(this.FormGenericError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenericError;
        private System.Windows.Forms.Button buttonOK;
    }
}