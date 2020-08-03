namespace Shopping
{
    partial class FrmAddProducts
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
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.dtGridViProducts = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewProduct = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.numUpDownProdPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViProducts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownProdPrice)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.panel2);
            this.pnlProducts.Controls.Add(this.panel1);
            this.pnlProducts.Controls.Add(this.btnClose);
            this.pnlProducts.Controls.Add(this.dtGridViProducts);
            this.pnlProducts.Location = new System.Drawing.Point(-6, 1);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(804, 446);
            this.pnlProducts.TabIndex = 0;
            // 
            // dtGridViProducts
            // 
            this.dtGridViProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtGridViProducts.Location = new System.Drawing.Point(0, 0);
            this.dtGridViProducts.Name = "dtGridViProducts";
            this.dtGridViProducts.Size = new System.Drawing.Size(804, 227);
            this.dtGridViProducts.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(688, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveProduct);
            this.panel1.Controls.Add(this.numUpDownProdPrice);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lblProductPrice);
            this.panel1.Controls.Add(this.lblNewProduct);
            this.panel1.Location = new System.Drawing.Point(49, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 85);
            this.panel1.TabIndex = 3;
            // 
            // lblNewProduct
            // 
            this.lblNewProduct.AutoSize = true;
            this.lblNewProduct.Location = new System.Drawing.Point(27, 15);
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(75, 13);
            this.lblNewProduct.TabIndex = 0;
            this.lblNewProduct.Text = "Product Name";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(27, 41);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Product Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(104, 12);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(120, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // numUpDownProdPrice
            // 
            this.numUpDownProdPrice.DecimalPlaces = 2;
            this.numUpDownProdPrice.Location = new System.Drawing.Point(104, 38);
            this.numUpDownProdPrice.Name = "numUpDownProdPrice";
            this.numUpDownProdPrice.Size = new System.Drawing.Size(120, 20);
            this.numUpDownProdPrice.TabIndex = 4;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(241, 47);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(75, 30);
            this.btnSaveProduct.TabIndex = 5;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(0, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 80);
            this.panel2.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(124, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 38);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FrmAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlProducts);
            this.Name = "FrmAddProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmAddProducts_Load);
            this.pnlProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownProdPrice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.DataGridView dtGridViProducts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numUpDownProdPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblNewProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}