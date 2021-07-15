
namespace AddressBook.Windows.Product
{
    partial class FormProducts
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
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriceUntaxed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTaxPercentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriceTaxed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBarcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVendor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPriceUntaxed = new System.Windows.Forms.Label();
            this.labelTaxPercentage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelReference = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelVendor = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewProducts);
            this.panel1.Controls.Add(this.groupBoxActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonReset);
            this.groupBoxActions.Controls.Add(this.labelVendor);
            this.groupBoxActions.Controls.Add(this.comboBox1);
            this.groupBoxActions.Controls.Add(this.labelBarcode);
            this.groupBoxActions.Controls.Add(this.labelReference);
            this.groupBoxActions.Controls.Add(this.textBox5);
            this.groupBoxActions.Controls.Add(this.textBox4);
            this.groupBoxActions.Controls.Add(this.textBox3);
            this.groupBoxActions.Controls.Add(this.textBox2);
            this.groupBoxActions.Controls.Add(this.textBox1);
            this.groupBoxActions.Controls.Add(this.labelTaxPercentage);
            this.groupBoxActions.Controls.Add(this.labelPriceUntaxed);
            this.groupBoxActions.Controls.Add(this.labelName);
            this.groupBoxActions.Controls.Add(this.textBoxID);
            this.groupBoxActions.Controls.Add(this.buttonDeleteProduct);
            this.groupBoxActions.Controls.Add(this.buttonEditProduct);
            this.groupBoxActions.Controls.Add(this.buttonAddProduct);
            this.groupBoxActions.Controls.Add(this.buttonReturn);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxActions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(800, 138);
            this.groupBoxActions.TabIndex = 0;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderPriceUntaxed,
            this.columnHeaderTaxPercentage,
            this.columnHeaderPriceTaxed,
            this.columnHeaderReference,
            this.columnHeaderBarcode,
            this.columnHeaderVendor});
            this.listViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(0, 138);
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(800, 312);
            this.listViewProducts.TabIndex = 1;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
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
            // columnHeaderReference
            // 
            this.columnHeaderReference.Text = "Reference";
            // 
            // columnHeaderBarcode
            // 
            this.columnHeaderBarcode.Text = "Barcode";
            // 
            // columnHeaderVendor
            // 
            this.columnHeaderVendor.Text = "Vendor";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(12, 19);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "<--- Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.Lime;
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 59);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 1;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEditProduct.Location = new System.Drawing.Point(93, 59);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonEditProduct.TabIndex = 2;
            this.buttonEditProduct.Text = "Edit";
            this.buttonEditProduct.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(174, 59);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProduct.TabIndex = 3;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(255, 61);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 92);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelPriceUntaxed
            // 
            this.labelPriceUntaxed.AutoSize = true;
            this.labelPriceUntaxed.Location = new System.Drawing.Point(116, 92);
            this.labelPriceUntaxed.Name = "labelPriceUntaxed";
            this.labelPriceUntaxed.Size = new System.Drawing.Size(72, 13);
            this.labelPriceUntaxed.TabIndex = 6;
            this.labelPriceUntaxed.Text = "Price untaxed";
            // 
            // labelTaxPercentage
            // 
            this.labelTaxPercentage.AutoSize = true;
            this.labelTaxPercentage.Location = new System.Drawing.Point(225, 92);
            this.labelTaxPercentage.Name = "labelTaxPercentage";
            this.labelTaxPercentage.Size = new System.Drawing.Size(82, 13);
            this.labelTaxPercentage.TabIndex = 7;
            this.labelTaxPercentage.Text = "Tax percentage";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(226, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(332, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(438, 108);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // labelReference
            // 
            this.labelReference.AutoSize = true;
            this.labelReference.Location = new System.Drawing.Point(332, 92);
            this.labelReference.Name = "labelReference";
            this.labelReference.Size = new System.Drawing.Size(57, 13);
            this.labelReference.TabIndex = 13;
            this.labelReference.Text = "Reference";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Location = new System.Drawing.Point(439, 92);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(69, 13);
            this.labelBarcode.TabIndex = 14;
            this.labelBarcode.Text = "labelBarcode";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // labelVendor
            // 
            this.labelVendor.AutoSize = true;
            this.labelVendor.Location = new System.Drawing.Point(541, 92);
            this.labelVendor.Name = "labelVendor";
            this.labelVendor.Size = new System.Drawing.Size(41, 13);
            this.labelVendor.TabIndex = 16;
            this.labelVendor.Text = "Vendor";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(498, 58);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormProducts";
            this.Text = "FormProduct";
            this.panel1.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPriceUntaxed;
        private System.Windows.Forms.ColumnHeader columnHeaderTaxPercentage;
        private System.Windows.Forms.ColumnHeader columnHeaderPriceTaxed;
        private System.Windows.Forms.ColumnHeader columnHeaderReference;
        private System.Windows.Forms.ColumnHeader columnHeaderBarcode;
        private System.Windows.Forms.ColumnHeader columnHeaderVendor;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTaxPercentage;
        private System.Windows.Forms.Label labelPriceUntaxed;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Label labelReference;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelVendor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonReset;
    }
}