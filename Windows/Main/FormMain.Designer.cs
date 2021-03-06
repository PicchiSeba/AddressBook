
namespace AddressBook.Windows.Main
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeAllPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billsRecievedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBackground.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBackground.BackgroundImage")));
            this.panelBackground.Controls.Add(this.menuStrip1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(757, 529);
            this.panelBackground.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsManagementToolStripMenuItem,
            this.addressesManagementToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.vendorsToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.billsRecievedToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.windowToolStripMenuItem.Text = "Data management";
            // 
            // contactsManagementToolStripMenuItem
            // 
            this.contactsManagementToolStripMenuItem.Name = "contactsManagementToolStripMenuItem";
            this.contactsManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactsManagementToolStripMenuItem.Text = "Contacts";
            this.contactsManagementToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactsManagementToolStripMenuItem.Click += new System.EventHandler(this.usersManagementToolStripMenuItem_Click);
            // 
            // addressesManagementToolStripMenuItem
            // 
            this.addressesManagementToolStripMenuItem.Name = "addressesManagementToolStripMenuItem";
            this.addressesManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addressesManagementToolStripMenuItem.Text = "Addresses";
            this.addressesManagementToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressesManagementToolStripMenuItem.Click += new System.EventHandler(this.addressesManagementToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeAllPaymentsToolStripMenuItem,
            this.addAPaymentToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // seeAllPaymentsToolStripMenuItem
            // 
            this.seeAllPaymentsToolStripMenuItem.Name = "seeAllPaymentsToolStripMenuItem";
            this.seeAllPaymentsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.seeAllPaymentsToolStripMenuItem.Text = "See all payments";
            this.seeAllPaymentsToolStripMenuItem.Click += new System.EventHandler(this.seeAllPaymentsToolStripMenuItem_Click);
            // 
            // addAPaymentToolStripMenuItem
            // 
            this.addAPaymentToolStripMenuItem.Name = "addAPaymentToolStripMenuItem";
            this.addAPaymentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addAPaymentToolStripMenuItem.Text = "Add a payment";
            this.addAPaymentToolStripMenuItem.Click += new System.EventHandler(this.addAPaymentToolStripMenuItem_Click);
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendorsToolStripMenuItem.Text = "Vendors";
            this.vendorsToolStripMenuItem.Click += new System.EventHandler(this.vendorsToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // billsRecievedToolStripMenuItem
            // 
            this.billsRecievedToolStripMenuItem.Name = "billsRecievedToolStripMenuItem";
            this.billsRecievedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billsRecievedToolStripMenuItem.Text = "Bills received";
            this.billsRecievedToolStripMenuItem.Click += new System.EventHandler(this.billsRecievedToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseConnectionToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // databaseConnectionToolStripMenuItem
            // 
            this.databaseConnectionToolStripMenuItem.Name = "databaseConnectionToolStripMenuItem";
            this.databaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.databaseConnectionToolStripMenuItem.Text = "Database connection";
            this.databaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.databaseConnectionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelBackground);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 529);
            this.panel1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 529);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeAllPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsRecievedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseConnectionToolStripMenuItem;
    }
}