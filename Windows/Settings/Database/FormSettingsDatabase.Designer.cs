
namespace AddressBook.Windows.Settings.Database
{
    partial class FormSettingsDatabase
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
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.buttonResetToDefault = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownPort);
            this.panel1.Controls.Add(this.buttonResetToDefault);
            this.panel1.Controls.Add(this.buttonSaveSettings);
            this.panel1.Controls.Add(this.buttonTestConnection);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Controls.Add(this.labelDatabase);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.textBoxDatabase);
            this.panel1.Controls.Add(this.labelPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelServer);
            this.panel1.Controls.Add(this.textBoxServer);
            this.panel1.Controls.Add(this.buttonReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 258);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(231, 70);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPort.TabIndex = 15;
            this.numericUpDownPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // buttonResetToDefault
            // 
            this.buttonResetToDefault.Location = new System.Drawing.Point(239, 222);
            this.buttonResetToDefault.Name = "buttonResetToDefault";
            this.buttonResetToDefault.Size = new System.Drawing.Size(92, 23);
            this.buttonResetToDefault.TabIndex = 14;
            this.buttonResetToDefault.Text = "Reset to default";
            this.buttonResetToDefault.UseVisualStyleBackColor = true;
            this.buttonResetToDefault.Click += new System.EventHandler(this.buttonResetToDefault_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(134, 222);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveSettings.TabIndex = 13;
            this.buttonSaveSettings.Text = "Save settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(15, 222);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(97, 23);
            this.buttonTestConnection.TabIndex = 12;
            this.buttonTestConnection.Text = "Test connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(115, 155);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 155);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "User";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(12, 104);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(53, 13);
            this.labelDatabase.TabIndex = 9;
            this.labelDatabase.Text = "Database";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(118, 171);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(12, 171);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 7;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(12, 120);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatabase.TabIndex = 6;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(231, 54);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(12, 54);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(38, 13);
            this.labelServer.TabIndex = 2;
            this.labelServer.Text = "Server";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(12, 70);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(192, 20);
            this.textBoxServer.TabIndex = 1;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(12, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "<--- Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormSettingsDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 258);
            this.Controls.Add(this.panel1);
            this.Name = "FormSettingsDatabase";
            this.Text = "FormSettingsDatabase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Button buttonResetToDefault;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
    }
}