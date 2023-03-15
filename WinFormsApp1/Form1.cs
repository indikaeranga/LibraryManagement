using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ConString cn = new ConString();
        
        public Form1()
        {
            InitializeComponent();

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btmadmin_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnte_Click(object sender, EventArgs e)
        {

        }

        private void btnte_Click_1(object sender, EventArgs e)
        {
            string nic = txtname_te.Text;
            string pass = txtpass_te.Text;
            if (nic != "" && pass != "")
            {
                string hashPassword = HashPassword(pass);
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "select name,password,access from Teacher_Admin where nic='" + nic + "' and password='" + hashPassword + "' ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][2].ToString() == "1")
                    {
                        con.Close();
                        this.Hide();
                        AdminDashboard ad = new AdminDashboard();
                        ad.Show();
                    }
                    else if (dt.Rows[0][2].ToString() == "0")
                    {
                        con.Close();
                        
                        this.Hide();
                        DashboradTeacher ud = new DashboradTeacher(get_teacher_name(nic, pass));
                        ud.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please check your username and password.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Username or password incorrect");
                }
            }
            else { MessageBox.Show("Username or password incorrect"); }
        }

        public string get_teacher_name(string nic , string pass)
        {
            string name = "";
            string hashPassword = HashPassword(pass);
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select name from Teacher_Admin where nic='" + nic + "' and password='" + hashPassword + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
                DataRow row = dta.Rows[0];
                name =   row[0].ToString();
            return name;
            con.Close();
            
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            DashboradTeacher ud = new DashboradTeacher("Simple Teacher");
            ud.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
           
        }
    }
}