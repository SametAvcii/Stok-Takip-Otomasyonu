
namespace Sifremi_Unuttum
{
    partial class Sifremi_Unuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sifremi_Unuttum));
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.lblHata = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cikis_yap = new System.Windows.Forms.Button();
            this.geri_git = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(425, 212);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(160, 22);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "E-Posta Adresiniz";
            this.lblMail.Click += new System.EventHandler(this.lblMail_Click);
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(369, 249);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(265, 40);
            this.txtMail.TabIndex = 1;
            this.txtMail.WordWrap = false;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.btnSendMail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendMail.ForeColor = System.Drawing.Color.Black;
            this.btnSendMail.Location = new System.Drawing.Point(431, 324);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(142, 43);
            this.btnSendMail.TabIndex = 2;
            this.btnSendMail.Text = "Mail Gönder";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Location = new System.Drawing.Point(12, 228);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(453, 295);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 10);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // cikis_yap
            // 
            this.cikis_yap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.cikis_yap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_yap.BackgroundImage")));
            this.cikis_yap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis_yap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cikis_yap.FlatAppearance.BorderSize = 0;
            this.cikis_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_yap.Location = new System.Drawing.Point(958, 12);
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
            // Sifremi_Unuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 531);
            this.Controls.Add(this.cikis_yap);
            this.Controls.Add(this.geri_git);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sifremi_Unuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.Sifremi_Unuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cikis_yap;
        private System.Windows.Forms.Button geri_git;
    }
}