using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Sifremi_Unuttum
{
    public partial class New_Brands : Form
    {
        public New_Brands()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");

        private void btnNewBrands_Click(object sender, EventArgs e)
        {
            if (txtNewBrad.Text!="")
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string brand = "insert into Brands(Brand_Name) values(@Brand)";
                    SqlCommand komut = new SqlCommand(brand, connect);
                    komut.Parameters.AddWithValue("@Brand", txtNewBrad.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Basarıyla Oluşturuldu");
                    connect.Close();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Bir hata oluştu" + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Marka Adı Giriniz");
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
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
