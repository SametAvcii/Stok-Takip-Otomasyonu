
namespace Sifremi_Unuttum
{
    partial class New_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Category));
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cikis_yap = new System.Windows.Forms.Button();
            this.geri_git = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.lblNewCategory.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.lblNewCategory.Location = new System.Drawing.Point(295, 150);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(196, 37);
            this.lblNewCategory.TabIndex = 0;
            this.lblNewCategory.Text = "Kategori Adı";
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtNewCategory.Location = new System.Drawing.Point(215, 215);
            this.txtNewCategory.Multiline = true;
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(350, 37);
            this.txtNewCategory.TabIndex = 1;
            this.txtNewCategory.WordWrap = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(327, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cikis_yap
            // 
            this.cikis_yap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(144)))));
            this.cikis_yap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_yap.BackgroundImage")));
            this.cikis_yap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis_yap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cikis_yap.FlatAppearance.BorderSize = 0;
            this.cikis_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_yap.Location = new System.Drawing.Point(750, 12);
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
            // New_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikis_yap);
            this.Controls.Add(this.geri_git);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNewCategory);
            this.Controls.Add(this.lblNewCategory);
            this.DoubleBuffered = true;
            this.Name = "New_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Ctegory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cikis_yap;
        private System.Windows.Forms.Button geri_git;
    }
}