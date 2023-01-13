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

namespace WinFormsApp1
{
    public partial class DashboradTeacher : Form
    {
        ConString cn = new ConString();
        public DashboradTeacher(string teacher)
        {
            InitializeComponent();
            lblteacher.Text = teacher;
            teachercount();
            studentcount();
            isbncount();
            totalbookcount();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManage ad = new StudentManage(lblteacher.Text);
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookInventory ad = new BookInventory(lblteacher.Text);
            ad.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void teachercount()
        {
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select count(*) from Teacher_Admin";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader re = cmd.ExecuteReader();
                re.Read();
                if (re.HasRows)
                {
                    lblteachercount.Text = re[0].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void studentcount()
        {
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select count(*) from student";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader re = cmd.ExecuteReader();
                re.Read();
                if (re.HasRows)
                {
                    lblstdcount.Text = re[0].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void isbncount()
        {
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select count(*) from book";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader re = cmd.ExecuteReader();
                re.Read();
                if (re.HasRows)
                {
                    lblisbncount.Text = re[0].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void totalbookcount()
        {
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select count(*) from book_inventory";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader re = cmd.ExecuteReader();
                re.Read();
                if (re.HasRows)
                {
                    lbltotalbooks.Text = re[0].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Issue_Book ad = new Issue_Book(lblteacher.Text);
            ad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentHistory ad = new StudentHistory(lblteacher.Text);
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return_Book ad = new Return_Book(lblteacher.Text);
            ad.Show();
        }
    }
}
