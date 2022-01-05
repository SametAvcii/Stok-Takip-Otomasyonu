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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");


        DataTable tablosatis = new DataTable();
        public void toplamSatis()
        {
            toplam = 0;
            try
            {
                gunluk_satis();
                dgvSold.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSold.Columns[0].HeaderText = "Barkod";
                dgvSold.Columns[1].HeaderText = "Ürün Adı";
                dgvSold.Columns[2].HeaderText = "Satış Fiyatı";
                dgvSold.Columns[3].HeaderText = "Satılan Ürün Adedi";
            }
            catch
            {

                ;
            }
            for (int i = 0; i < dgvSold.Rows.Count - 1; i++)
            {
                if (dgvSold.Rows[i].Cells[3].Value.ToString() != "0" && dgvSold.Rows[i].Cells[3].Value.ToString() != "")
                {
                    toplam += (Convert.ToSingle(dgvSold.Rows[i].Cells[2].Value.ToString())) * (Convert.ToSingle(dgvSold.Rows[i].Cells[3].Value.ToString()));
                }
                else
                {
                    toplam += Convert.ToSingle(dgvSold.Rows[i].Cells[2].Value.ToString());
                } 
            }
            txtPrice.Text = toplam.ToString();

        }
        public void gunluk_satis()
        {
            connect.Open();
            tablosatis.Clear();
            SqlDataAdapter dta = new SqlDataAdapter("select Barkod,Name,Sales_Price,Quantity_Of_Sold_Product from Sold_Product where Date='" + dtpHome.Text + "'", connect);
            dta.Fill(tablosatis);
            dgvSold.DataSource = tablosatis;
            connect.Close();
            
        }
        private void New_Product_Click(object sender, EventArgs e)
        {
            New_Product Yeni_Urun = new New_Product();
            Yeni_Urun.Show();
            this.Close();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            New_Category new_Category = new New_Category();
            new_Category.Show();
            this.Close();
        }

        private void btnNewBrand_Click(object sender, EventArgs e)
        {
            New_Brands new_Brands = new New_Brands();
            new_Brands.Show();
            this.Close();
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            List_Product list_Product = new List_Product();
            list_Product.Show();
            this.Close();
        }

        private void btnSales_Prod_Click(object sender, EventArgs e)
        {
            Product_Sales product_Sales = new Product_Sales();
            product_Sales.Show();
            this.Close();
        }
  
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            New_Customer new_customer = new New_Customer();
            new_customer.Show();
            this.Close();
        }

        private void btnDebt_Click(object sender, EventArgs e)
        {
            Debt_Receive Debt = new Debt_Receive();
            Debt.Show();
            this.Close();
        }

        float toplam = new float();
        private void Home_Page_Load(object sender, EventArgs e)
        {
            toplamSatis();
          
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width = panel2.Width + 1;
            if (panel2.Width == 196)
            {
                timer1.Stop();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Width = panel2.Width -1;
            if (panel2.Width==56)
            {
                timer2.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Width==56)
            {
                timer1.Start();
            }
            else
            {
                timer2.Start();
            }
        }

        private void btn_oturumKapat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Geri gitmek istiyor musunuz ? (Yeniden giriş yapmak zorundasınız.)", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Giris_Ekrani backHomeScreen = new Giris_Ekrani();
                this.Hide();
                backHomeScreen.Show();
            }
            else
            {
                MessageBox.Show("İşleminiz iptal edildi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void cikis_yap_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void geri_git_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Geri gitmek istiyor musunuz ? (Yeniden giriş yapmak zorundasınız.)", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Giris_Ekrani backHomeScreen = new Giris_Ekrani ();
                this.Hide();
                backHomeScreen.Show();
            }
            else
            {
                MessageBox.Show("İşleminiz iptal edildi");
            }
        }

        private void dtpHome_ValueChanged_1(object sender, EventArgs e)
        {
            toplamSatis();
        }
    }
}
