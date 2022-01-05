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
    public partial class New_Product : Form
    {

        public New_Product()
        {
            InitializeComponent();
        }
        
        static string conString = "Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void New_Product_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            SqlCommand komutBrand = new SqlCommand();

            komut.CommandText = "select*from Category ";
            komutBrand.CommandText = "select*from Brands";


            komut.Connection = connect;
            komut.CommandType = CommandType.Text;

            komutBrand.Connection = connect;
            komutBrand.CommandType = CommandType.Text;

            SqlDataReader dr;
            SqlDataReader drBrand;
            connect.Open();
            dr = komut.ExecuteReader();
             
            while (dr.Read())
            {
                cbCategory.Items.Add(dr["Category_Names"]);
            }

          
            connect.Close();
            connect.Open();
            drBrand = komutBrand.ExecuteReader();
            while (drBrand.Read())
            {
                cbBrand.Items.Add(drBrand["Brand_Name"]);
            }
            connect.Close();
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            if (txtName.Text!=""&& txtBarkod.Text!=""&&txtPrice.Text!=""&& txtStock.Text!="")
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    string new_product = "insert into Product_Property (Name,Barkod_Number,Stock_Number,Sales_Price,Discount_Percentage,Category_Name,Brand_Name) values(@Name,@Barkod_Number,@Stock_Number,@Sales_Price,@Discount_Percentage,@Category_Name,@Brand_Name)";
                    SqlCommand komut1 = new SqlCommand(new_product, connect);
                    komut1.Parameters.AddWithValue("@Stock_Number", txtStock.Text);
                    komut1.Parameters.AddWithValue("@Barkod_Number", txtBarkod.Text);
                    komut1.Parameters.AddWithValue("@Discount_Percentage", txtDiscount.Text);
                    komut1.Parameters.AddWithValue("@Sales_Price", txtPrice.Text);
                    komut1.Parameters.AddWithValue("@Category_Name", cbCategory.SelectedItem);
                    komut1.Parameters.AddWithValue("@Brand_Name", cbBrand.SelectedItem);
                    komut1.Parameters.AddWithValue("@Name", txtName.Text);

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
            Home_Page home_Page = new Home_Page();
            home_Page.Show();
            this.Close();
        }

   

        private void New_Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            List_Product list = new List_Product();
            list.table();
        }
    }
}
