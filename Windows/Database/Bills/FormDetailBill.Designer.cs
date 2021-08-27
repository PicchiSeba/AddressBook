
namespace AddressBook.Windows.Bills
{
    partial class FormBillDetail
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewBillsDetailBill = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProductUntaxed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProductTaxed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewProductsDetailBill = new System.Windows.Forms.ListView();
            this.columnHeaderIDProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriceUntaxed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTaxPercentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriceTaxed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelUnitsDetailBill = new System.Windows.Forms.Label();
            this.buttonProductPageBillDetail = new System.Windows.Forms.Button();
            this.textBoxUnitsBillDetail = new System.Windows.Forms.TextBox();
            this.buttonDeleteBillDetail = new System.Windows.Forms.Button();
            this.buttonEditBillDetail = new System.Windows.Forms.Button();
            this.buttonAddBillDetail = new System.Windows.Forms.Button();
            this.buttonReturnBillDetail = new System.Windows.Forms.Button();
            this.buttonExportPDF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBoxActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 301);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listViewBillsDetailBill, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewProductsDetailBill, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listViewBillsDetailBill
            // 
            this.listViewBillsDetailBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderProductID,
            this.columnHeaderUnits,
            this.columnHeaderProductName,
            this.columnHeaderProductUntaxed,
            this.columnHeaderProductTaxed});
            this.listViewBillsDetailBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBillsDetailBill.FullRowSelect = true;
            this.listViewBillsDetailBill.GridLines = true;
            this.listViewBillsDetailBill.HideSelection = false;
            this.listViewBillsDetailBill.Location = new System.Drawing.Point(3, 3);
            this.listViewBillsDetailBill.Name = "listViewBillsDetailBill";
            this.listViewBillsDetailBill.Size = new System.Drawing.Size(384, 295);
            this.listViewBillsDetailBill.TabIndex = 0;
            this.listViewBillsDetailBill.UseCompatibleStateImageBehavior = false;
            this.listViewBillsDetailBill.View = System.Windows.Forms.View.Details;
            this.listViewBillsDetailBill.SelectedIndexChanged += new System.EventHandler(this.listViewBillsDetailBill_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderProductID
            // 
            this.columnHeaderProductID.Text = "Product ID";
            // 
            // columnHeaderUnits
            // 
            this.columnHeaderUnits.Text = "Units";
            // 
            // columnHeaderProductName
            // 
            this.columnHeaderProductName.Text = "Product name";
            // 
            // columnHeaderProductUntaxed
            // 
            this.columnHeaderProductUntaxed.Text = "Product untaxed";
            // 
            // columnHeaderProductTaxed
            // 
            this.columnHeaderProductTaxed.Text = "Product taxed";
            this.columnHeaderProductTaxed.Width = 69;
            // 
            // listViewProductsDetailBill
            // 
            this.listViewProductsDetailBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIDProduct,
            this.columnHeaderName,
            this.columnHeaderPriceUntaxed,
            this.columnHeaderTaxPercentage,
            this.columnHeaderPriceTaxed});
            this.listViewProductsDetailBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProductsDetailBill.FullRowSelect = true;
            this.listViewProductsDetailBill.GridLines = true;
            this.listViewProductsDetailBill.HideSelection = false;
            this.listViewProductsDetailBill.Location = new System.Drawing.Point(393, 3);
            this.listViewProductsDetailBill.Name = "listViewProductsDetailBill";
            this.listViewProductsDetailBill.Size = new System.Drawing.Size(384, 295);
            this.listViewProductsDetailBill.TabIndex = 1;
            this.listViewProductsDetailBill.UseCompatibleStateImageBehavior = false;
            this.listViewProductsDetailBill.View = System.Windows.Forms.View.Details;
            this.listViewProductsDetailBill.SelectedIndexChanged += new System.EventHandler(this.listViewProductsDetailBill_SelectedIndexChanged);
            // 
            // columnHeaderIDProduct
            // 
            this.columnHeaderIDProduct.Text = "ID";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderPriceUntaxed
            // 
            this.columnHeaderPriceUntaxed.Text = "Price untaxed";
            // 
            // columnHeaderTaxPercentage
            // 
            this.columnHeaderTaxPercentage.Text = "Tax percentage";
            // 
            // columnHeaderPriceTaxed
            // 
            this.columnHeaderPriceTaxed.Text = "Price taxed";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonExportPDF);
            this.groupBoxActions.Controls.Add(this.textBoxID);
            this.groupBoxActions.Controls.Add(this.labelUnitsDetailBill);
            this.groupBoxActions.Controls.Add(this.buttonProductPageBillDetail);
            this.groupBoxActions.Controls.Add(this.textBoxUnitsBillDetail);
            this.groupBoxActions.Controls.Add(this.buttonDeleteBillDetail);
            this.groupBoxActions.Controls.Add(this.buttonEditBillDetail);
            this.groupBoxActions.Controls.Add(this.buttonAddBillDetail);
            this.groupBoxActions.Controls.Add(this.buttonReturnBillDetail);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxActions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(780, 149);
            this.groupBoxActions.TabIndex = 0;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(255, 64);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 10;
            this.textBoxID.Text = "ID";
            // 
            // labelUnitsDetailBill
            // 
            this.labelUnitsDetailBill.AutoSize = true;
            this.labelUnitsDetailBill.Location = new System.Drawing.Point(270, 89);
            this.labelUnitsDetailBill.Name = "labelUnitsDetailBill";
            this.labelUnitsDetailBill.Size = new System.Drawing.Size(31, 13);
            this.labelUnitsDetailBill.TabIndex = 9;
            this.labelUnitsDetailBill.Text = "Units";
            // 
            // buttonProductPageBillDetail
            // 
            this.buttonProductPageBillDetail.Location = new System.Drawing.Point(393, 64);
            this.buttonProductPageBillDetail.Name = "buttonProductPageBillDetail";
            this.buttonProductPageBillDetail.Size = new System.Drawing.Size(75, 20);
            this.buttonProductPageBillDetail.TabIndex = 8;
            this.buttonProductPageBillDetail.Text = "Products page";
            this.buttonProductPageBillDetail.UseVisualStyleBackColor = true;
            this.buttonProductPageBillDetail.Click += new System.EventHandler(this.buttonProductPageBillDetail_Click);
            // 
            // textBoxUnitsBillDetail
            // 
            this.textBoxUnitsBillDetail.Location = new System.Drawing.Point(273, 105);
            this.textBoxUnitsBillDetail.Name = "textBoxUnitsBillDetail";
            this.textBoxUnitsBillDetail.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitsBillDetail.TabIndex = 6;
            // 
            // buttonDeleteBillDetail
            // 
            this.buttonDeleteBillDetail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDeleteBillDetail.Location = new System.Drawing.Point(174, 62);
            this.buttonDeleteBillDetail.Name = "buttonDeleteBillDetail";
            this.buttonDeleteBillDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteBillDetail.TabIndex = 5;
            this.buttonDeleteBillDetail.Text = "Delete";
            this.buttonDeleteBillDetail.UseVisualStyleBackColor = false;
            this.buttonDeleteBillDetail.Click += new System.EventHandler(this.buttonDeleteBillDetail_Click);
            // 
            // buttonEditBillDetail
            // 
            this.buttonEditBillDetail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEditBillDetail.Location = new System.Drawing.Point(93, 62);
            this.buttonEditBillDetail.Name = "buttonEditBillDetail";
            this.buttonEditBillDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonEditBillDetail.TabIndex = 3;
            this.buttonEditBillDetail.Text = "Edit";
            this.buttonEditBillDetail.UseVisualStyleBackColor = false;
            this.buttonEditBillDetail.Click += new System.EventHandler(this.buttonEditBillDetail_Click);
            // 
            // buttonAddBillDetail
            // 
            this.buttonAddBillDetail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonAddBillDetail.Location = new System.Drawing.Point(12, 62);
            this.buttonAddBillDetail.Name = "buttonAddBillDetail";
            this.buttonAddBillDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBillDetail.TabIndex = 1;
            this.buttonAddBillDetail.Text = "Add";
            this.buttonAddBillDetail.UseVisualStyleBackColor = false;
            this.buttonAddBillDetail.Click += new System.EventHandler(this.buttonAddBillDetail_Click);
            // 
            // buttonReturnBillDetail
            // 
            this.buttonReturnBillDetail.Location = new System.Drawing.Point(12, 19);
            this.buttonReturnBillDetail.Name = "buttonReturnBillDetail";
            this.buttonReturnBillDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonReturnBillDetail.TabIndex = 0;
            this.buttonReturnBillDetail.Text = "<--- Return";
            this.buttonReturnBillDetail.UseVisualStyleBackColor = true;
            this.buttonReturnBillDetail.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.Location = new System.Drawing.Point(383, 19);
            this.buttonExportPDF.Name = "buttonExportPDF";
            this.buttonExportPDF.Size = new System.Drawing.Size(92, 23);
            this.buttonExportPDF.TabIndex = 11;
            this.buttonExportPDF.Text = "Export to PDF";
            this.buttonExportPDF.UseVisualStyleBackColor = true;
            this.buttonExportPDF.Click += new System.EventHandler(this.buttonExportPDF_Click);
            // 
            // FormBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormBillDetail";
            this.Text = "FormBillDetail";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonReturnBillDetail;
        private System.Windows.Forms.Button buttonDeleteBillDetail;
        private System.Windows.Forms.Button buttonEditBillDetail;
        private System.Windows.Forms.Button buttonAddBillDetail;
        private System.Windows.Forms.Button buttonProductPageBillDetail;
        private System.Windows.Forms.TextBox textBoxUnitsBillDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewBillsDetailBill;
        private System.Windows.Forms.ListView listViewProductsDetailBill;
        private System.Windows.Forms.Label labelUnitsDetailBill;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderProductID;
        private System.Windows.Forms.ColumnHeader columnHeaderUnits;
        private System.Windows.Forms.ColumnHeader columnHeaderProductName;
        private System.Windows.Forms.ColumnHeader columnHeaderProductUntaxed;
        private System.Windows.Forms.ColumnHeader columnHeaderProductTaxed;
        private System.Windows.Forms.ColumnHeader columnHeaderIDProduct;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPriceUntaxed;
        private System.Windows.Forms.ColumnHeader columnHeaderTaxPercentage;
        private System.Windows.Forms.ColumnHeader columnHeaderPriceTaxed;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonExportPDF;
    }
}