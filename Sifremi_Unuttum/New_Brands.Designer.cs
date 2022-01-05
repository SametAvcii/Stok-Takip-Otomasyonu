
namespace Sifremi_Unuttum
{
    partial class New_Brands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Brands));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewBrad = new System.Windows.Forms.TextBox();
            this.btnNewBrands = new System.Windows.Forms.Button();
            this.cikis_yap = new System.Windows.Forms.Button();
            this.geri_git = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.label1.Location = new System.Drawing.Point(280, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // txtNewBrad
            // 
            this.txtNewBrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewBrad.Location = new System.Drawing.Point(187, 215);
            this.txtNewBrad.Multiline = true;
            this.txtNewBrad.Name = "txtNewBrad";
            this.txtNewBrad.Size = new System.Drawing.Size(350, 37);
            this.txtNewBrad.TabIndex = 1;
            // 
            // btnNewBrands
            // 
            this.btnNewBrands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnNewBrands.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewBrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBrands.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnNewBrands.Location = new System.Drawing.Point(300, 275);
            this.btnNewBrands.Name = "btnNewBrands";
            this.btnNewBrands.Size = new System.Drawing.Size(130, 40);
            this.btnNewBrands.TabIndex = 2;
            this.btnNewBrands.Text = "Kaydet";
            this.btnNewBrands.UseVisualStyleBackColor = false;
            this.btnNewBrands.Click += new System.EventHandler(this.btnNewBrands_Click);
            // 
            // cikis_yap
            // 
            this.cikis_yap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.cikis_yap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_yap.BackgroundImage")));
            this.cikis_yap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis_yap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cikis_yap.FlatAppearance.BorderSize = 0;
            this.cikis_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_yap.Location = new System.Drawing.Point(671, 12);
            this.cikis_yap.Name = "cikis_yap";
            this.cikis_yap.Size = new System.Drawing.Size(38, 41);
            this.cikis_yap.TabIndex = 69;
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
            this.geri_git.TabIndex = 68;
            this.geri_git.UseVisualStyleBackColor = false;
            this.geri_git.Click += new System.EventHandler(this.geri_git_Click);
            // 
            // New_Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 429);
            this.Controls.Add(this.cikis_yap);
            this.Controls.Add(this.geri_git);
            this.Controls.Add(this.btnNewBrands);
            this.Controls.Add(this.txtNewBrad);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "New_Brands";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Brads";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewBrad;
        private System.Windows.Forms.Button btnNewBrands;
        private System.Windows.Forms.Button cikis_yap;
        private System.Windows.Forms.Button geri_git;
    }
}