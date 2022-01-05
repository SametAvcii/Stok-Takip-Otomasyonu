using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sifremi_Unuttum
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        static string conString = "Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void btnRegister_Click_1(object sender, EventArgs e)
        {



            try
            {

                if (txtName.Text!=""&& txtUserName.Text!=""&&txtPhoneNumber.Text!=""&&txtEmail.Text!="")
                {

                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    SqlCommand sql1 = new SqlCommand("select UserName from UserName where Name='" + txtUserName.Text + "'", connect);
                    SqlDataReader dr = sql1.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Girilen kullanıcı Sisteme Kayıtlı");
                    }
                    else
                    {
                        string kayit = "insert into UserName (Name,SurName,UserName,Password,PhoneNumber,Email) values(@Name,@SurName,@UserName,@Password,@PhoneNumber,@Email)";
                        SqlCommand komut = new SqlCommand(kayit, connect);
                        komut.Parameters.AddWithValue("@Name", txtName.Text);
                        komut.Parameters.AddWithValue("@SurName", txtSurName.Text);
                        komut.Parameters.AddWithValue("@UserName", txtUserName.Text);
                        komut.Parameters.AddWithValue("@Password", txtPassword.Text);
                        komut.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                        komut.ExecuteNonQuery();

                        connect.Close();
                        MessageBox.Show("Kayıt Başarıyla Tamamlandı");

                        Giris_Ekrani giris_Ekrani = new Giris_Ekrani();
                        giris_Ekrani.Show();
                        this.Close();

                    }



                }
                else
                {
                    MessageBox.Show("Lütfen Gerekli Bilgileri Giriniz.");
                }
            }


            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu" + hata.Message);
            }
        }

        private void pctBoxSignUp_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSurName_Click(object sender, EventArgs e)
        {

        }

        private void txtSurName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void geri_git_Click(object sender, EventArgs e)
        {
            Giris_Ekrani giris = new Giris_Ekrani();
            this.Hide();
            giris.Show();
        }
    }
}
