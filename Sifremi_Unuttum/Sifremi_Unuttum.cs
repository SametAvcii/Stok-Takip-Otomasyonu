using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Sifremi_Unuttum
{
    public partial class Sifremi_Unuttum : Form
    {
        public Sifremi_Unuttum()
        {
            InitializeComponent();
        }

        public Sifremi_Unuttum(string sifre)
        {
            this.sifre = sifre;
        }

        public bool mailGonder (string konu, string icerik)
        {
            MailMessage eMail = new MailMessage();
            eMail.From = new MailAddress("gs-194@hotmail.com");
            eMail.To.Add(txtMail.Text);
            eMail.Subject = konu;
            eMail.Body = icerik;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("your-emailadress", "your-emailPassword");
            client.Port = 587;
            client.Host = "smtp.outlook.com";
            client.EnableSsl = true;
            client.Send(eMail);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(eMail, (object)eMail);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;

        }

        string sifre;

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection("Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
                if (connect.State==ConnectionState.Closed)
                {
                    connect.Open();
                }
                SqlCommand komut = new SqlCommand("select * from UserName where Email='" + txtMail.Text + "'");
                {
                    komut.Connection = connect;
                };
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    sifre = oku["Password"].ToString();

                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Green;
                    lblHata.Text = "Girmiş Olduğunuz Bilgiler Uyuşuyor Şifreniz Mail Olarak Gönderildi";

                

                    progressBar1.Visible = true;
                    progressBar1.Maximum = 900000;
                    progressBar1.Minimum = 90;

                    for (int j = 90; j < 900000; j++)
                    {
                        progressBar1.Value = j;
                    }

                    mailGonder("ŞİFRE HATIRLATMA", "Şifreniz: " + sifre);
                    connect.Close();
                }
                else
                {
                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Red;
                    lblHata.Text = "Girmiş Olduğunuz Bilgiler Uyuşmuyor";
                }
            }
            catch (Exception)
            {
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Mail Gönderme Hatası";
            }

            Giris_Ekrani giris_Ekrani = new Giris_Ekrani();
            giris_Ekrani.Show();
            this.Close();

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
           
        }

        private void Sifremi_Unuttum_Load(object sender, EventArgs e)
        {

        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void geri_git_Click(object sender, EventArgs e)
        {
            Giris_Ekrani giris_Ekrani = new Giris_Ekrani();
            giris_Ekrani.Show();
            this.Close();
        }

        private void cikis_yap_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
