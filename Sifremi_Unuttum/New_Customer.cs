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
    public partial class New_Customer : Form
    {
        public New_Customer()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text!="" &&txtSurName.Text!="" &&txtPhoneNumber.Text!="")
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    string new_product = "insert into Customers (Name,Sur_Name,Phone_Number,E_Mail,Job) values(@Name,@Sur_Name,@Phone_Number,@E_Mail,@Job)";

                    SqlCommand komut1 = new SqlCommand(new_product, connect);


                    komut1.Parameters.AddWithValue("@Name", txtName.Text);
                    komut1.Parameters.AddWithValue("@Sur_Name", txtSurName.Text);
                    komut1.Parameters.AddWithValue("@Phone_Number", txtPhoneNumber.Text);
                    komut1.Parameters.AddWithValue("@E_Mail", txtEMail.Text);
                    komut1.Parameters.AddWithValue("@Job", txtJob.Text);


                    komut1.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Oluşturdu");
                    connect.Close();
                }
                catch (Exception Hata)
                {
                    MessageBox.Show("Bir hata oluştu" + Hata.Message);

                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Boşlukları Doldurunuz");
            }
           
        }

        private void cikis_yap_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void geri_git_Click(object sender, EventArgs e)
        {
            Home_Page home = new Home_Page();
            this.Hide();
            home.Show();
        }
    }
}
