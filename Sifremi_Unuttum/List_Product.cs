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
    public partial class List_Product : Form
    {
        public List_Product()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        public void category_and_brand()
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
        public void table()
        {
            connect.Open();
            string Select = "select * from Product_Property";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Select, connect);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dgwProd.DataSource = table;
            connect.Close();
        }
        private void List_Product_Load(object sender, EventArgs e)
        {
            table();
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            bool SayiMi(string text)
            {
                foreach (char chr in text)
                {
                    if (!Char.IsNumber(chr)) return false;
                }
                return true;
            }
            if (SayiMi(txtBarkod.Text) == true)
            {
                string select = "select Name,Brand_Name,Sales_Price,Stock_Number,Barkod_Number,Discount_Percentage from Product_Property where Barkod_Number=@barkod";
                SqlCommand komut = new SqlCommand(select, connect);
                komut.Parameters.AddWithValue("@barkod", txtBarkod.Text);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgwProd.DataSource = dataTable;
                connect.Close();
            }
            else
            {
                string select = "select Name,Brand_Name,Sales_Price,Stock_Number,Barkod_Number,Discount_Percentage from Product_Property where (Name like '%" + txtBarkod.Text + "%')or(Brand_Name like '%" + txtBarkod.Text + "%')";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select, connect);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgwProd.DataSource = dataTable;
                connect.Close();
            }
        }
        private void btnDeleteProduct_Click_1(object sender, EventArgs e)
        {

            if (connect.State == ConnectionState.Closed)
                connect.Open();
            string barkod = dgwProd.CurrentRow.Cells[1].Value.ToString();
            SqlCommand delete = new SqlCommand("Delete from Product_Property where Barkod_Number='" + txtBarkod.Text + "'", connect);
            delete.ExecuteNonQuery();
            connect.Close();
            table();
            MessageBox.Show("Silme İşlemi Başarılı");
            textBox1.Text = barkod;
        }
        private void btnRefreshProduct_Click_1(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            string ID = dgwProd.CurrentRow.Cells[0].Value.ToString();
            string Barkod_Number= dgwProd.CurrentRow.Cells[1].Value.ToString();

            if (Barkod_Number == txtBarkod.Text)
            {
                SqlCommand sql = new SqlCommand("update Product_Property set Name='" + txtName.Text + "',Category_Name='" + cbCategory.SelectedItem + "',Stock_Number='" + txtStock.Text + "',Brand_Name='" + cbBrand.SelectedItem + "',Sales_Price='" + txtPrice.Text + "',Discount_Percentage='" + txtDiscount.Text + "' where ID='" + ID + "'", connect);
                sql.ExecuteNonQuery();
                connect.Close();
                table();
                MessageBox.Show("Ürün Bilgileri Başarıyla Güncellendi");
            }
            else
            {
                SqlCommand sql = new SqlCommand("update Product_Property set Name='" + txtName.Text + "',Category_Name='" + cbCategory.SelectedItem + "',Stock_Number='" + txtStock.Text + "',Barkod_Number='"+txtBarkod.Text+"',Brand_Name='" + cbBrand.SelectedItem + "',Sales_Price='" + txtPrice.Text + "',Discount_Percentage='" + txtDiscount.Text + "' where ID='" + ID + "'", connect);
                sql.ExecuteNonQuery();
                connect.Close();
                table();
                MessageBox.Show("Ürün Bilgileri Başarıyla Güncellendi");
            }
            
            

        }
        private void dgwProd_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgwProd.SelectedCells[2].Value.ToString();
            txtBarkod.Text = dgwProd.SelectedCells[1].Value.ToString();
            txtPrice.Text = dgwProd.SelectedCells[5].Value.ToString();
            txtDiscount.Text = dgwProd.SelectedCells[6].Value.ToString();
            txtStock.Text = dgwProd.SelectedCells[7].Value.ToString();
            category_and_brand();
            cbCategory.SelectedItem = dgwProd.SelectedCells[3].Value.ToString();
            cbBrand.SelectedItem = dgwProd.SelectedCells[4].Value.ToString();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            home_Page.Show();
            this.Close();
        }
        private void btnListProd_Click(object sender, EventArgs e)
        {
            table();
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

        private void button1_Click(object sender, EventArgs e)
        {
            New_Product prod = new New_Product();
            prod.Show();
        }
    }

}
