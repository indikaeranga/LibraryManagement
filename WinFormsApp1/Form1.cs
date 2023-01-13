using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ConString cn = new ConString();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btmadmin_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboradTeacher ad = new DashboradTeacher("Teacher");
            ad.Show();
        }

        private void btnte_Click(object sender, EventArgs e)
        {

        }

        private void btnte_Click_1(object sender, EventArgs e)
        {
            string uname = txtname_te.Text;
            string pass = txtpass_te.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                con.Open();
                string sql = "select name,password,access from Teacher_Admin where name='" + uname + "' and password='" + pass + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][2].ToString() == "1")
                {
                    this.Hide();
                    AdminDashboard ad = new AdminDashboard();
                    ad.Show();
                }
                else if (dt.Rows[0][2].ToString() == "0")
                {
                    this.Hide();
                    DashboradTeacher ud = new DashboradTeacher(uname);
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
    }
}