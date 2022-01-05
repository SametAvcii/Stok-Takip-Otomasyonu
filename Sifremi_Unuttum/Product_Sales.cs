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
    public partial class Product_Sales : Form
    {
        public Product_Sales()
        {
            InitializeComponent();
        }
        
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        DataTable tablo = new DataTable();
        public void DgwProdToDgv2()
        {
           
            tablo.Rows.Add(dgwProd.CurrentRow.Cells[0].Value.ToString(), dgwProd.CurrentRow.Cells[1].Value.ToString(), dgwProd.CurrentRow.Cells[2].Value.ToString(), dgwProd.CurrentRow.Cells[3].Value, dgwProd.CurrentRow.Cells[4].Value.ToString(), dgwProd.CurrentRow.Cells[5].Value.ToString(), txtNumber.Text);
            dgv2.DataSource = tablo;
            toplam = 0;

            string Sales_Price, Discount_Percentage;
            for (int i = 0; i < dgv2.Rows.Count - 1; i++)
            {
                Discount_Percentage = dgv2.Rows[i].Cells[5].Value.ToString();
                Sales_Price = dgv2.Rows[i].Cells[2].Value.ToString();

                if (txtDisc.Text != "0" && txtDisc.Text != "")
                {
                    if (dgv2.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        toplam += (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value)) - Convert.ToSingle(Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * (Convert.ToSingle(dgv2.Rows[i].Cells[5].Value)) / 100);

                        txtPrice.Text = Convert.ToString(toplam);
                    }
                    else if (dgv2.Rows[i].Cells[6].Value.ToString() == "0")
                    {
                        txtPrice.Text = Convert.ToString(toplam);
                    }
                    else
                    {
                        toplam += (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) - (Convert.ToSingle(Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * (Convert.ToSingle(dgv2.Rows[i].Cells[5].Value)) / 100))) * Convert.ToSingle(dgv2.Rows[i].Cells[6].Value);
                        txtPrice.Text = Convert.ToString(toplam);
                    }
                }
                else if (Discount_Percentage != "" && Discount_Percentage != "0" && txtDisc.Text == "")
                {

                    if (dgv2.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        toplam += (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value)) - Convert.ToSingle(Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * (Convert.ToSingle(dgv2.Rows[i].Cells[5].Value)) / 100);

                        txtPrice.Text = Convert.ToString(toplam);
                    }
                    else if (dgv2.Rows[i].Cells[6].Value.ToString() == "0")
                    {
                        txtPrice.Text = Convert.ToString(toplam);
                    }
                    else
                    {
                       toplam += ((Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) - Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * Convert.ToSingle(dgv2.Rows[i].Cells[5].Value) / 100) * Convert.ToSingle(dgv2.Rows[i].Cells[6].Value));
                       txtPrice.Text = Convert.ToString(toplam);
                    }


                    //toplam += (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value)) - Convert.ToSingle(Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * (Convert.ToSingle(dgv2.Rows[i].Cells[5].Value)) / 100);
                    //txtPrice.Text = Convert.ToString(toplam);
                }
                else if (Discount_Percentage == "" || Discount_Percentage == "0" || txtDisc.Text == "")
                {
                    toplam += (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value)* Convert.ToSingle(dgv2.Rows[i].Cells[6].Value));
                    txtPrice.Text = Convert.ToString(toplam);
                }
            }
            txtNumber.Text = "";
        }
        public void Tablo1()
        {
            SqlCommand sql = new SqlCommand("select Name,Brand_Name,Sales_Price,Stock_Number,Barkod_Number,Discount_Percentage from Product_Property", connect);
            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable table = new DataTable();
            sda.Fill(table);
            dgwProd.DataSource = table;
        }
        public void No_Result()
        {
            MessageBox.Show("Ürün bulunamadı tekrar deneyin");
            Tablo1();
        }

        public void sales()
        {
            connect.Open();
            float toplam = 0;
            string Barkod_Number, stock ,Stock2, Sales_Price, Name, Date, Discount_Percentage; int Stock1 = 0, Quantity_Of_Sold_Product=0;
            for (int i = 0; i < dgv2.Rows.Count - 1; i++)
            {
                Sales_Price = "";
                Barkod_Number = dgv2.Rows[i].Cells[4].Value.ToString();
                stock = dgv2.Rows[i].Cells[3].Value.ToString();                   
                Name = dgv2.Rows[i].Cells[0].Value.ToString();
                Discount_Percentage= dgv2.Rows[i].Cells[5].Value.ToString();
                if (txtDisc.Text != "0" && txtDisc.Text != "")
                {
                   Sales_Price= ((Convert.ToSingle(dgv2.Rows[i].Cells[2].Value)) - Convert.ToSingle(Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * (Convert.ToSingle(txtDisc.Text)) / 100)).ToString();
                }
                else if (Discount_Percentage != "" && Discount_Percentage != "0" && txtDisc.Text == "")
                {
                    Sales_Price = ((Convert.ToSingle(dgv2.Rows[i].Cells[2].Value)) - Convert.ToSingle(Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * (Convert.ToSingle(dgv2.Rows[i].Cells[5].Value)) / 100)).ToString();
                }
                else if (Discount_Percentage == "" || Discount_Percentage == "0" || txtDisc.Text == "")
                {
                    Sales_Price = ((Convert.ToSingle(dgv2.Rows[i].Cells[2].Value))).ToString(); 
                }
                Stock1 = Convert.ToInt32(stock);
                
                if (dgv2.Rows[i].Cells[6].Value.ToString() !=""&& dgv2.Rows[i].Cells[6].Value.ToString()!="0")
                {
                    Stock1 -= Convert.ToInt32(dgv2.Rows[i].Cells[6].Value.ToString());
                }
                else
                {
                    Stock1--;
                }
                Stock2 = Convert.ToString(Stock1);
                if(dgv2.Rows[i].Cells[6].Value.ToString()!="0"&& dgv2.Rows[i].Cells[6].Value.ToString() != "")
                {
                    Quantity_Of_Sold_Product = Convert.ToInt32(dgv2.Rows[i].Cells[6].Value.ToString());
                }
                if (Convert.ToSingle(Stock2)>=0)
                {
                    SqlCommand komut = new SqlCommand("Update Product_Property set Stock_Number='" + Stock2 + "' where Barkod_Number='" + Barkod_Number + "'", connect);
                    SqlCommand sold = new SqlCommand("insert into Sold_Product(Name,Barkod,Date,Sales_Price,Discount_Percentage,Quantity_Of_Sold_Product) values('" + Name + "','" + Barkod_Number + "','" + dtpSales.Text + "','" + Sales_Price + "','" + Discount_Percentage + "','" + Quantity_Of_Sold_Product + "')", connect);
                    komut.ExecuteNonQuery();
                    sold.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("'"+dgv2.Rows[i].Cells[0].Value.ToString()+"' Ürünü Stokta Kalmadı Satış Ekranından Kaldırınız");
                }


            }
            txtPrice.Text = Convert.ToString(toplam);
            connect.Close();
            tablo.Rows.Clear();
            Tablo1();
        }
        private void Product_Sales_Load_1(object sender, EventArgs e)
        {
            Tablo1();
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Marka", typeof(string));
            tablo.Columns.Add("TUTAR", typeof(string));
            tablo.Columns.Add("Stok Miktarı", typeof(string));
            tablo.Columns.Add("Barkod", typeof(string));
            tablo.Columns.Add("İndirim Yüzdesi", typeof(string));
            tablo.Columns.Add("Satılan Adet ", typeof(string));
            dgv2.DataSource = tablo;


        }
        float toplam = 0;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
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

                DgwProdToDgv2();
            }
            catch (Exception)
            {

                No_Result();
            }         

        }
        private void dgv2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedrowcount = dgv2.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedrowcount > 0)
            {
                for (int i = 0; i < selectedrowcount; i++)
                {
                    dgv2.Rows.RemoveAt(dgv2.SelectedRows[0].Index);
                }
            }
            toplam = 0;
            if (dgv2.Rows.Count > 0)
            {
                for (int i = 0; i < dgv2.Rows.Count; i++)
                {

                    //toplam -= Convert.ToSingle(dgv2.CurrentRow.Cells[2].Value);
                    //textBox1.Text = Convert.ToString(dgv2.CurrentRow.Cells[2].Value);
                    toplam += (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value)) - Convert.ToSingle(Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * (Convert.ToSingle(dgv2.Rows[i].Cells[5].Value)) / 100);

                }
                txtPrice.Text = Convert.ToString(toplam);
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            sales();
        }
        string[] product = new string[40];
        private void btnDebt_Click(object sender, EventArgs e)
        {
            Debt_Receive debt = new Debt_Receive();
            //for (int i = 0; i < dgv2.Rows.Count;  i++)
            //{
            //    product[i] = (Convert.ToString(dgv2.Rows[i].Cells[0].Value)); 
            //    //debt.lstbxProd.Items.Add(product[i]);
            //}
            debt.txtPrice.Text = txtPrice.Text;
            debt.Show();

            sales();
        }
        private void btnDiscount_Click_1(object sender, EventArgs e)
        {
            toplam = 0;
            for (int i = 0; i < dgv2.Rows.Count - 1; i++)
            {
                string Disc_Perc = txtDisc.Text;
                if (dgv2.Rows[i].Cells[6].Value.ToString() == "")
                {
                    toplam += (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) - (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * Convert.ToSingle(Disc_Perc) / 100));
                    txtPrice.Text = Convert.ToString(toplam);
                }
                else if (dgv2.Rows[i].Cells[6].Value.ToString() == "0")
                {
                    toplam += (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) - (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * Convert.ToSingle(Disc_Perc) / 100));
                    txtPrice.Text = Convert.ToString(toplam);
                }
                else
                {
                    toplam += (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) - (Convert.ToSingle(dgv2.Rows[i].Cells[2].Value) * Convert.ToSingle(Disc_Perc) / 100)) * Convert.ToSingle(dgv2.Rows[i].Cells[6].Value);
                    txtPrice.Text = Convert.ToString(toplam);
                }
            }
        }

        private void dgwProd_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DgwProdToDgv2();
        }

    

        private void btnNumber_Click(object sender, EventArgs e)
        {
            DgwProdToDgv2();  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void geri_git_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_Page home = new Home_Page();
            this.Hide();
            home.Show();
        }
    }
}
