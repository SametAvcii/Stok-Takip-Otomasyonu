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
    public partial class Update_Customers : Form
    {
        public Update_Customers()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand com = new SqlCommand("update Customers Set Name='" + txtName.Text + "',Sur_Name='" + txtSurName.Text + "',Phone_Number='" + txtPhoneNumber.Text + "',E_Mail='" + txtEMail.Text + "',Job='" + txtJob.Text + "',Total_Receive='" + txtDebt.Text + "' where ID='" + txtID.Text + "'", connect);
            com.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme Başarılı");
            this.Close();
            
        }

        private void cikis_yap_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void geri_git_Click(object sender, EventArgs e)
        {
            Debt_Receive dept = new Debt_Receive();
            this.Hide();
            dept.Show();
        }
    }
}
