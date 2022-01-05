
namespace Sifremi_Unuttum
{
    partial class Product_Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Sales));
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.dgwProd = new System.Windows.Forms.DataGridView();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnDebt = new System.Windows.Forms.Button();
            this.dtpSales = new System.Windows.Forms.DateTimePicker();
            this.lblDısc = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnNumber = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtBarkod.Location = new System.Drawing.Point(156, 130);
            this.txtBarkod.Multiline = true;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(242, 37);
            this.txtBarkod.TabIndex = 0;
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblBarkod.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblBarkod.Location = new System.Drawing.Point(23, 129);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(127, 37);
            this.lblBarkod.TabIndex = 1;
            this.lblBarkod.Text = "Barkod:";
            // 
            // dgwProd
            // 
            this.dgwProd.AllowUserToAddRows = false;
            this.dgwProd.AllowUserToDeleteRows = false;
            this.dgwProd.AllowUserToResizeColumns = false;
            this.dgwProd.AllowUserToResizeRows = false;
            this.dgwProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.dgwProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProd.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwProd.Location = new System.Drawing.Point(30, 169);
            this.dgwProd.Name = "dgwProd";
            this.dgwProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProd.Size = new System.Drawing.Size(471, 215);
            this.dgwProd.TabIndex = 2;
            this.dgwProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProd_CellDoubleClick_1);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnSales.Location = new System.Drawing.Point(768, 335);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(250, 49);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Satış";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnSearch.Location = new System.Drawing.Point(404, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 37);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.Location = new System.Drawing.Point(722, 390);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(115, 37);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Text = "\r\n\r\n";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblPrice.Location = new System.Drawing.Point(507, 390);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(209, 37);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Toplam Fiyat:";
            // 
            // dgv2
            // 
            this.dgv2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.GridColor = System.Drawing.Color.Black;
            this.dgv2.Location = new System.Drawing.Point(507, 169);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.Size = new System.Drawing.Size(511, 162);
            this.dgv2.TabIndex = 7;
            this.dgv2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellDoubleClick_1);
            // 
            // btnDebt
            // 
            this.btnDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnDebt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebt.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnDebt.Location = new System.Drawing.Point(507, 335);
            this.btnDebt.Name = "btnDebt";
            this.btnDebt.Size = new System.Drawing.Size(250, 49);
            this.btnDebt.TabIndex = 8;
            this.btnDebt.Text = "Hesaba Gönder";
            this.btnDebt.UseVisualStyleBackColor = false;
            this.btnDebt.Click += new System.EventHandler(this.btnDebt_Click);
            // 
            // dtpSales
            // 
            this.dtpSales.Location = new System.Drawing.Point(873, 104);
            this.dtpSales.Name = "dtpSales";
            this.dtpSales.Size = new System.Drawing.Size(145, 20);
            this.dtpSales.TabIndex = 10;
            // 
            // lblDısc
            // 
            this.lblDısc.AutoSize = true;
            this.lblDısc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblDısc.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblDısc.Location = new System.Drawing.Point(507, 130);
            this.lblDısc.Name = "lblDısc";
            this.lblDısc.Size = new System.Drawing.Size(232, 37);
            this.lblDısc.TabIndex = 12;
            this.lblDısc.Text = "İskonto Miktarı:";
            // 
            // txtDisc
            // 
            this.txtDisc.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtDisc.Location = new System.Drawing.Point(745, 130);
            this.txtDisc.Multiline = true;
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(170, 37);
            this.txtDisc.TabIndex = 13;
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnDiscount.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Location = new System.Drawing.Point(921, 130);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(97, 37);
            this.btnDiscount.TabIndex = 16;
            this.btnDiscount.Text = "İndirim Uygula";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click_1);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtNumber.Location = new System.Drawing.Point(125, 390);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(273, 37);
            this.txtNumber.TabIndex = 17;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblNumber.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblNumber.Location = new System.Drawing.Point(23, 390);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(96, 37);
            this.lblNumber.TabIndex = 18;
            this.lblNumber.Text = "Adet:";
            // 
            // btnNumber
            // 
            this.btnNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnNumber.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnNumber.Location = new System.Drawing.Point(404, 390);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(97, 37);
            this.btnNumber.TabIndex = 19;
            this.btnNumber.Text = "Ekle";
            this.btnNumber.UseVisualStyleBackColor = false;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 71;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(969, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 58);
            this.button2.TabIndex = 70;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Product_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.lblDısc);
            this.Controls.Add(this.dtpSales);
            this.Controls.Add(this.btnDebt);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.dgwProd);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.txtBarkod);
            this.DoubleBuffered = true;
            this.Name = "Product_Sales";
            this.Text = "Product_Sales";
            this.Load += new System.EventHandler(this.Product_Sales_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.DataGridView dgwProd;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.DataGridView dgv2;
        public System.Windows.Forms.Button btnDebt;
        private System.Windows.Forms.DateTimePicker dtpSales;
        private System.Windows.Forms.Label lblDısc;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}