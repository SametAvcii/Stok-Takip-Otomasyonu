
namespace Sifremi_Unuttum
{
    partial class List_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Product));
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnRefreshProduct = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblBrad = new System.Windows.Forms.Label();
            this.lblProdCategory = new System.Windows.Forms.Label();
            this.dgwProd = new System.Windows.Forms.DataGridView();
            this.btnListProd = new System.Windows.Forms.Button();
            this.geri_git = new System.Windows.Forms.Button();
            this.cikis_yap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnDeleteProduct.Location = new System.Drawing.Point(784, 391);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(165, 40);
            this.btnDeleteProduct.TabIndex = 62;
            this.btnDeleteProduct.Text = "Ürünü Sil";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnSearch.Location = new System.Drawing.Point(621, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 37);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.label1.Location = new System.Drawing.Point(111, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ürün Ara:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(265, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 37);
            this.textBox1.TabIndex = 59;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(402, 344);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 44;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(328, 344);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 18);
            this.lblName.TabIndex = 58;
            this.lblName.Text = "Ürün Adı:";
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(402, 394);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(213, 21);
            this.cbBrand.TabIndex = 46;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(402, 367);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(213, 21);
            this.cbCategory.TabIndex = 45;
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnRefreshProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefreshProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshProduct.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnRefreshProduct.Location = new System.Drawing.Point(784, 345);
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.Size = new System.Drawing.Size(165, 40);
            this.btnRefreshProduct.TabIndex = 53;
            this.btnRefreshProduct.Text = "Ürünü Güncelle";
            this.btnRefreshProduct.UseVisualStyleBackColor = false;
            this.btnRefreshProduct.Click += new System.EventHandler(this.btnRefreshProduct_Click_1);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(402, 498);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(213, 20);
            this.txtDiscount.TabIndex = 51;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(402, 472);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(213, 20);
            this.txtPrice.TabIndex = 49;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(402, 446);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(213, 20);
            this.txtStock.TabIndex = 48;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(402, 420);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(213, 20);
            this.txtBarkod.TabIndex = 47;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiscount.Location = new System.Drawing.Point(286, 500);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(111, 18);
            this.lblDiscount.TabIndex = 50;
            this.lblDiscount.Text = "İndirim Yüzdesi:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(313, 474);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(83, 18);
            this.lblPrice.TabIndex = 52;
            this.lblPrice.Text = "Satış Fiyatı:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStock.Location = new System.Drawing.Point(306, 448);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(91, 18);
            this.lblStock.TabIndex = 54;
            this.lblStock.Text = "Stok Miktarı:";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.Location = new System.Drawing.Point(336, 420);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(60, 18);
            this.lblBarkod.TabIndex = 55;
            this.lblBarkod.Text = "Barkod:";
            // 
            // lblBrad
            // 
            this.lblBrad.AutoSize = true;
            this.lblBrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblBrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrad.Location = new System.Drawing.Point(331, 394);
            this.lblBrad.Name = "lblBrad";
            this.lblBrad.Size = new System.Drawing.Size(65, 18);
            this.lblBrad.TabIndex = 56;
            this.lblBrad.Text = "Markası:";
            // 
            // lblProdCategory
            // 
            this.lblProdCategory.AutoSize = true;
            this.lblProdCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblProdCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProdCategory.Location = new System.Drawing.Point(283, 370);
            this.lblProdCategory.Name = "lblProdCategory";
            this.lblProdCategory.Size = new System.Drawing.Size(114, 18);
            this.lblProdCategory.TabIndex = 57;
            this.lblProdCategory.Text = "Ürün Kategorisi:";
            // 
            // dgwProd
            // 
            this.dgwProd.AllowUserToAddRows = false;
            this.dgwProd.AllowUserToDeleteRows = false;
            this.dgwProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgwProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.dgwProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProd.GridColor = System.Drawing.Color.Black;
            this.dgwProd.Location = new System.Drawing.Point(118, 142);
            this.dgwProd.Name = "dgwProd";
            this.dgwProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProd.Size = new System.Drawing.Size(831, 188);
            this.dgwProd.TabIndex = 42;
            this.dgwProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProd_CellDoubleClick_1);
            // 
            // btnListProd
            // 
            this.btnListProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnListProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnListProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProd.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnListProd.Location = new System.Drawing.Point(784, 437);
            this.btnListProd.Name = "btnListProd";
            this.btnListProd.Size = new System.Drawing.Size(165, 40);
            this.btnListProd.TabIndex = 41;
            this.btnListProd.Text = "Ürünleri Listele";
            this.btnListProd.UseVisualStyleBackColor = false;
            this.btnListProd.Click += new System.EventHandler(this.btnListProd_Click);
            // 
            // geri_git
            // 
            this.geri_git.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.geri_git.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri_git.BackgroundImage")));
            this.geri_git.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri_git.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.geri_git.FlatAppearance.BorderSize = 0;
            this.geri_git.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri_git.Location = new System.Drawing.Point(10, 11);
            this.geri_git.Name = "geri_git";
            this.geri_git.Size = new System.Drawing.Size(58, 58);
            this.geri_git.TabIndex = 65;
            this.geri_git.UseVisualStyleBackColor = false;
            this.geri_git.Click += new System.EventHandler(this.geri_git_Click);
            // 
            // cikis_yap
            // 
            this.cikis_yap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.cikis_yap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_yap.BackgroundImage")));
            this.cikis_yap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis_yap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cikis_yap.FlatAppearance.BorderSize = 0;
            this.cikis_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_yap.Location = new System.Drawing.Point(980, 11);
            this.cikis_yap.Name = "cikis_yap";
            this.cikis_yap.Size = new System.Drawing.Size(58, 58);
            this.cikis_yap.TabIndex = 64;
            this.cikis_yap.UseVisualStyleBackColor = false;
            this.cikis_yap.Click += new System.EventHandler(this.cikis_yap_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.button1.Location = new System.Drawing.Point(784, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 40);
            this.button1.TabIndex = 66;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // List_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.geri_git);
            this.Controls.Add(this.cikis_yap);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnRefreshProduct);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblBrad);
            this.Controls.Add(this.lblProdCategory);
            this.Controls.Add(this.dgwProd);
            this.Controls.Add(this.btnListProd);
            this.DoubleBuffered = true;
            this.Name = "List_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Product";
            this.Load += new System.EventHandler(this.List_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnRefreshProduct;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblBrad;
        private System.Windows.Forms.Label lblProdCategory;
        private System.Windows.Forms.DataGridView dgwProd;
        private System.Windows.Forms.Button btnListProd;
        private System.Windows.Forms.Button geri_git;
        private System.Windows.Forms.Button cikis_yap;
        private System.Windows.Forms.Button button1;
    }
}