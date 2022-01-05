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
using System.Data.Sql;

namespace Sifremi_Unuttum
{
    public partial class Debt_Receive : Form
    {
        public Debt_Receive()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        public void Sales_Debt()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            string Name = dgvCust.SelectedCells[1].Value.ToString();
            string Sur_Name = dgvCust.SelectedCells[2].Value.ToString();
            string Phone_Number = dgvCust.SelectedCells[4].Value.ToString();
            string Total_Receive;
            if (txtMoney.Text != "" && txtMoney.Text != "0")
            {
                Total_Receive = txtMoney.Text;
                SqlCommand sql2 = new SqlCommand("insert Sales_Debt(Name,Sur_Name,Phone_Number,Total_Receive,Date)values('" + Name + "','" + Sur_Name + "','" + Phone_Number + "','" + Total_Receive + "','" + dtpDebt.Text + "')", connect);
                sql2.ExecuteNonQuery();
            }
            else if (txtPrice.Text != "0")
            {

                Total_Receive = txtPrice.Text;
                SqlCommand sql2 = new SqlCommand("insert Sales_Debt(Name,Sur_Name,Phone_Number,Total_Receive,Date)values('" + Name + "','" + Sur_Name + "','" + Phone_Number + "','" + Total_Receive + "','" + dtpDebt.Text + "')", connect);
                sql2.ExecuteNonQuery();
            }

            connect.Close();


            tablo();
            txtMoney.Text = "0";
        }
        public void Sales_Debt_Ext()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            string Name = dgvCust.SelectedCells[1].Value.ToString();
            string Sur_Name = dgvCust.SelectedCells[2].Value.ToString();
            string Phone_Number = dgvCust.SelectedCells[4].Value.ToString();
            string Total_Receive;
            float Total_Receive1;

            Total_Receive1 = (-Convert.ToSingle(txtMoney.Text));
            string total = Convert.ToString(Total_Receive1);
            SqlCommand sql2 = new SqlCommand("insert Sales_Debt(Name,Sur_Name,Phone_Number,Total_Receive,Date)values('" + Name + "','" + Sur_Name + "','" + Phone_Number + "','" + total + "','" + dtpDebt.Text + "')", connect);
            sql2.ExecuteNonQuery();
            connect.Close();
        }
        public void tablo()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            string Select = "select ID,Name,Sur_Name,E_Mail,Phone_Number, Total_Receive,Job from Customers";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Select, connect);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dgvCust.DataSource = table;
            connect.Close();
        }
        private void Debt_Receive_Load(object sender, EventArgs e)
        {
            tablo();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();

            string select = "Select * From Customers" + " where(name like '%" + txtSearch.Text + "%') or (Sur_Name like '%" + txtSearch.Text + "%')or(E_Mail like '%" + txtSearch.Text + "%')or(Phone_Number like '%" + txtSearch.Text + "%')or(Job like '%" + txtSearch.Text + "%')";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select, connect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvCust.DataSource = dataTable;
            connect.Close();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            string ID;
            if (dgvCust.SelectedCells[5].Value.ToString() == "")
            {
                ID = dgvCust.SelectedCells[0].Value.ToString();
                string toplam = Convert.ToString(Convert.ToSingle(txtPrice.Text));
                SqlCommand sql = new SqlCommand("update Customers Set Total_Receive ='" + toplam + "' where ID='" + ID + "'", connect);
                sql.ExecuteNonQuery();
            }
            else
            {
                try
                {
                    ID = dgvCust.SelectedCells[0].Value.ToString();
                    string toplam = Convert.ToString(Convert.ToSingle(dgvCust.SelectedCells[5].Value.ToString()) + Convert.ToSingle(txtPrice.Text));
                    SqlCommand sql = new SqlCommand("update Customers Set Total_Receive ='" + toplam + "' where ID='" + ID + "'", connect);
                    sql.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir Hata Oluştu Lütfen Farklı Bir Şey Deneyiniz");
                }

            }
            if (txtPrice.Text != "0")
                Sales_Debt();
            connect.Close();
            txtPrice.Text = Convert.ToString(0);
            tablo();
            connect.Open();
            //for (int i = 0; i < lstbxProd.Items.Count-1; i++)
            //{
            //    string prod = Convert.ToString(lstbxProd.Items[i]);
            //    SqlCommand sql1 = new SqlCommand("Update Customers Set Receive_Product ='" + prod + "' where ID='" + ID + "'", connect);
            //    sql1.ExecuteNonQuery();     
            //}





        }

        private void lblPlus_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();

            if (dgvCust.SelectedCells[5].Value.ToString() == "")
            {
                string ID = dgvCust.SelectedCells[0].Value.ToString();
                string toplam = Convert.ToString(Convert.ToSingle(txtMoney.Text));
                SqlCommand sql = new SqlCommand("update Customers Set Total_Receive ='" + toplam + "' where ID='" + ID + "'", connect);
                sql.ExecuteNonQuery();


            }
            else if (txtMoney.Text != "0" && txtMoney.Text != "")
            {
                string ID = dgvCust.SelectedCells[0].Value.ToString();
                string toplam = Convert.ToString(Convert.ToSingle(dgvCust.SelectedCells[5].Value.ToString()) + Convert.ToSingle(txtMoney.Text));
                SqlCommand sql = new SqlCommand("update Customers Set Total_Receive ='" + toplam + "' where ID='" + ID + "'", connect);

                sql.ExecuteNonQuery();
            }

            Sales_Debt();
        }

        private void lblExt_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            if (dgvCust.SelectedCells[5].Value.ToString() == "")
            {
                string ID = dgvCust.SelectedCells[0].Value.ToString();
                string toplam = Convert.ToString(-Convert.ToSingle(txtMoney.Text));
                SqlCommand sql = new SqlCommand("update Customers Set Total_Receive ='" + toplam + "' where ID='" + ID + "'", connect);
                sql.ExecuteNonQuery();
            }
            else
            {
                string ID = dgvCust.SelectedCells[0].Value.ToString();
                string toplam = Convert.ToString(Convert.ToSingle(dgvCust.SelectedCells[5].Value.ToString()) - Convert.ToSingle(txtMoney.Text));
                SqlCommand sql = new SqlCommand("update Customers Set Total_Receive ='" + toplam + "' where ID='" + ID + "'", connect);
                sql.ExecuteNonQuery();
            }
            connect.Close();

            Sales_Debt_Ext();
            tablo();


            txtMoney.Text = "0";
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            New_Customer cust = new New_Customer();
            cust.Show();
            tablo();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Customers update = new Update_Customers();
            update.Show();
            update.txtID.Text= dgvCust.CurrentRow.Cells[0].Value.ToString();
            update.txtName.Text = dgvCust.CurrentRow.Cells[1].Value.ToString();
            update.txtSurName.Text = dgvCust.CurrentRow.Cells[2].Value.ToString();
            update.txtPhoneNumber.Text = dgvCust.CurrentRow.Cells[3].Value.ToString();
            update.txtEMail.Text = dgvCust.CurrentRow.Cells[4].Value.ToString();
            update.txtDebt.Text = dgvCust.CurrentRow.Cells[5].Value.ToString();
            update.txtJob.Text = dgvCust.CurrentRow.Cells[6].Value.ToString();

        }
        private void dgvCust_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            string Phone_number = dgvCust.SelectedCells[4].Value.ToString();
            SqlCommand sql3 = new SqlCommand("select total_receive,date from Sales_Debt where Phone_Number='" + Phone_number + "'", connect);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql3);
            DataTable dt2 = new DataTable();
            sqlDataAdapter.Fill(dt2);
            dgv2.DataSource = dt2;
            connect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name, surname;
            name = dgvCust.CurrentRow.Cells[1].Value.ToString();
            surname = dgvCust.CurrentRow.Cells[2].Value.ToString();
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(""+name+""+ surname+"isimli Müşteriyi Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string ID = dgvCust.CurrentRow.Cells[0].Value.ToString();
                SqlCommand sql = new SqlCommand("delete from Customers where ID='" + ID + "'", connect);
                sql.ExecuteNonQuery();
                connect.Close();
                tablo();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tablo();
        }

        private void cikis_yap_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void geri_git_Click(object sender, EventArgs e)
        {
            Home_Page home = new Home_Page();
            home.Show();
            this.Close();
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';


        }
    }
}

