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
    public partial class Giris_Ekrani : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Giris_Ekrani()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string password = txtPassword.Text;
            con = new SqlConnection("Data Source=DESKTOP-DRVH66G\\SQLEXPRESS;Initial Catalog=Stok_Takip_Otomasyonu;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select*from UserName where UserName='" + txtUserName.Text +
                "' And Password='" + txtPassword.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                Home_Page Home_Page = new Home_Page();
                Home_Page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
            con.Close();
        }
        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp SignUp = new SignUp();
            SignUp.Show();
            this.Hide();
        }
        private void linklblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sifremi_Unuttum sifremi_Unuttum = new Sifremi_Unuttum();
            sifremi_Unuttum.Show();
            this.Hide();
        }
        private void Giris_Ekrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        }
        }

