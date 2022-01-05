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
    public partial class New_Category : Form
    {
      public  SqlConnection connect = new SqlConnection("Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        public New_Category()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewCategory.Text!="")
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string category = "insert into Category (Category_Names) values(@Category)";
                    SqlCommand komut = new SqlCommand(category, connect);
                    komut.Parameters.AddWithValue("@Category", txtNewCategory.Text);
                    komut.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Kayıt Başarıyla Oluşturuldu");


                }
                catch (Exception hata)
                {

                    MessageBox.Show("Bir hata oluştu" + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kategori Adı Giriniz");
            }
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            home_Page.Show();
            this.Close();
        }

        private void cikis_yap_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void geri_git_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            home_Page.Show();
            this.Close();
        }
    }
}
