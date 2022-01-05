
namespace Sifremi_Unuttum
{
    partial class Debt_Receive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debt_Receive));
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Button();
            this.lblExt = new System.Windows.Forms.Button();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpDebt = new System.Windows.Forms.DateTimePicker();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cikis_yap = new System.Windows.Forms.Button();
            this.geri_git = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblPrice.Location = new System.Drawing.Point(639, 169);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(94, 37);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Fiyat:";
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblSearch.Location = new System.Drawing.Point(23, 125);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 38);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "İsim:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtSearch.Location = new System.Drawing.Point(99, 126);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 37);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnSearch.Location = new System.Drawing.Point(455, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 38);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToDeleteRows = false;
            this.dgvCust.AllowUserToResizeColumns = false;
            this.dgvCust.AllowUserToResizeRows = false;
            this.dgvCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCust.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.dgvCust.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.GridColor = System.Drawing.Color.Black;
            this.dgvCust.Location = new System.Drawing.Point(30, 169);
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.ReadOnly = true;
            this.dgvCust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCust.Size = new System.Drawing.Size(610, 237);
            this.dgvCust.TabIndex = 6;
            this.dgvCust.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCust_CellDoubleClick_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnAdd.Location = new System.Drawing.Point(757, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(221, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Müşteriye Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtPrice.Location = new System.Drawing.Point(728, 169);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(266, 37);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtMoney.Location = new System.Drawing.Point(742, 412);
            this.txtMoney.Multiline = true;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(250, 37);
            this.txtMoney.TabIndex = 11;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblMoney.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblMoney.Location = new System.Drawing.Point(644, 412);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(92, 37);
            this.lblMoney.TabIndex = 12;
            this.lblMoney.Text = "Para:";
            // 
            // lblPlus
            // 
            this.lblPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.lblPlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lblPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlus.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lblPlus.Location = new System.Drawing.Point(834, 455);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(170, 40);
            this.lblPlus.TabIndex = 13;
            this.lblPlus.Text = "Ekle";
            this.lblPlus.UseVisualStyleBackColor = false;
            this.lblPlus.Click += new System.EventHandler(this.lblPlus_Click);
            // 
            // lblExt
            // 
            this.lblExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.lblExt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lblExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExt.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lblExt.Location = new System.Drawing.Point(680, 455);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(148, 40);
            this.lblExt.TabIndex = 14;
            this.lblExt.Text = "Çıkart";
            this.lblExt.UseVisualStyleBackColor = false;
            this.lblExt.Click += new System.EventHandler(this.lblExt_Click);
            // 
            // btnNewCust
            // 
            this.btnNewCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnNewCust.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCust.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnNewCust.Location = new System.Drawing.Point(30, 412);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(130, 40);
            this.btnNewCust.TabIndex = 15;
            this.btnNewCust.Text = "Yeni Müşteri";
            this.btnNewCust.UseVisualStyleBackColor = false;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnUpdate.Location = new System.Drawing.Point(166, 412);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpDebt
            // 
            this.dtpDebt.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDebt.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDebt.Location = new System.Drawing.Point(757, 126);
            this.dtpDebt.Name = "dtpDebt";
            this.dtpDebt.Size = new System.Drawing.Size(237, 26);
            this.dtpDebt.TabIndex = 19;
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.GridColor = System.Drawing.Color.Black;
            this.dgv2.Location = new System.Drawing.Point(644, 259);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(348, 147);
            this.dgv2.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnDelete.Location = new System.Drawing.Point(302, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Müşteri Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnRefresh.Location = new System.Drawing.Point(438, 412);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(159, 40);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Tabloyu Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cikis_yap
            // 
            this.cikis_yap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.cikis_yap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_yap.BackgroundImage")));
            this.cikis_yap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis_yap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cikis_yap.FlatAppearance.BorderSize = 0;
            this.cikis_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_yap.Location = new System.Drawing.Point(966, 12);
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
            // Debt_Receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 523);
            this.Controls.Add(this.cikis_yap);
            this.Controls.Add(this.geri_git);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dtpDebt);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNewCust);
            this.Controls.Add(this.lblExt);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCust);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblPrice);
            this.DoubleBuffered = true;
            this.Name = "Debt_Receive";
            this.Text = "Debt_Receive";
            this.Load += new System.EventHandler(this.Debt_Receive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.DataGridView dgvCust;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button lblPlus;
        private System.Windows.Forms.Button lblExt;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpDebt;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button cikis_yap;
        private System.Windows.Forms.Button geri_git;
    }
}