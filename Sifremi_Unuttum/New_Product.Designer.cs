
namespace Sifremi_Unuttum
{
    partial class New_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Product));
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnNewProduct = new System.Windows.Forms.Button();
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cikis_yap = new System.Windows.Forms.Button();
            this.geri_git = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBrand
            // 
            this.cbBrand.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(332, 210);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(350, 38);
            this.cbBrand.TabIndex = 3;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(332, 160);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(350, 38);
            this.cbCategory.TabIndex = 2;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnNewProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnNewProduct.Location = new System.Drawing.Point(445, 460);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(130, 40);
            this.btnNewProduct.TabIndex = 8;
            this.btnNewProduct.Text = "Kayıt Ekle";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtDiscount.Location = new System.Drawing.Point(332, 410);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(350, 37);
            this.txtDiscount.TabIndex = 7;
            this.txtDiscount.WordWrap = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtPrice.Location = new System.Drawing.Point(332, 360);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(350, 37);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.WordWrap = false;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtStock.Location = new System.Drawing.Point(332, 310);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(350, 37);
            this.txtStock.TabIndex = 5;
            this.txtStock.WordWrap = false;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtBarkod.Location = new System.Drawing.Point(332, 260);
            this.txtBarkod.Multiline = true;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(350, 37);
            this.txtBarkod.TabIndex = 4;
            this.txtBarkod.WordWrap = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblDiscount.Location = new System.Drawing.Point(95, 410);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(231, 37);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "İndirim Yüzdesi";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblPrice.Location = new System.Drawing.Point(163, 360);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(163, 37);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Satış Fiyatı";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblStock.Location = new System.Drawing.Point(145, 310);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(181, 37);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stok Miktarı";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblBarkod.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblBarkod.Location = new System.Drawing.Point(207, 260);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(119, 37);
            this.lblBarkod.TabIndex = 9;
            this.lblBarkod.Text = "Barkod";
            // 
            // lblBrad
            // 
            this.lblBrad.AutoSize = true;
            this.lblBrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblBrad.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblBrad.Location = new System.Drawing.Point(198, 210);
            this.lblBrad.Name = "lblBrad";
            this.lblBrad.Size = new System.Drawing.Size(128, 37);
            this.lblBrad.TabIndex = 10;
            this.lblBrad.Text = "Markası";
            // 
            // lblProdCategory
            // 
            this.lblProdCategory.AutoSize = true;
            this.lblProdCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblProdCategory.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblProdCategory.Location = new System.Drawing.Point(94, 160);
            this.lblProdCategory.Name = "lblProdCategory";
            this.lblProdCategory.Size = new System.Drawing.Size(232, 37);
            this.lblProdCategory.TabIndex = 11;
            this.lblProdCategory.Text = "Ürün Kategorisi";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblName.Location = new System.Drawing.Point(188, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 37);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Ürün Adı";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtName.Location = new System.Drawing.Point(332, 110);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 37);
            this.txtName.TabIndex = 1;
            this.txtName.WordWrap = false;
            // 
            // cikis_yap
            // 
            this.cikis_yap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.cikis_yap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_yap.BackgroundImage")));
            this.cikis_yap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis_yap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cikis_yap.FlatAppearance.BorderSize = 0;
            this.cikis_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_yap.Location = new System.Drawing.Point(948, 12);
            this.cikis_yap.Name = "cikis_yap";
            this.cikis_yap.Size = new System.Drawing.Size(38, 41);
            this.cikis_yap.TabIndex = 67;
            this.cikis_yap.UseVisualStyleBackColor = false;
            this.cikis_yap.Click += new System.EventHandler(this.cikis_yap_Click);
            // 
            // geri_git
            // 
            this.geri_git.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.geri_git.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri_git.BackgroundImage")));
            this.geri_git.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri_git.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.geri_git.FlatAppearance.BorderSize = 0;
            this.geri_git.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri_git.Location = new System.Drawing.Point(12, 12);
            this.geri_git.Name = "geri_git";
            this.geri_git.Size = new System.Drawing.Size(38, 41);
            this.geri_git.TabIndex = 66;
            this.geri_git.UseVisualStyleBackColor = false;
            this.geri_git.Click += new System.EventHandler(this.geri_git_Click);
            // 
            // New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 531);
            this.Controls.Add(this.cikis_yap);
            this.Controls.Add(this.geri_git);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnNewProduct);
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
            this.DoubleBuffered = true;
            this.Name = "New_Product";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni_Urun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.New_Product_FormClosed);
            this.Load += new System.EventHandler(this.New_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnNewProduct;
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cikis_yap;
        private System.Windows.Forms.Button geri_git;
    }
}