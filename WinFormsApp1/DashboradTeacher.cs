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
            need_return_books();
            due_books();
        }
        private Size formSize;
        private void btnstudent_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            StudentManage ad = new StudentManage(lblteacher.Text,this.formSize);
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            BookInventory ad = new BookInventory(lblteacher.Text, this.formSize);
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

        private void need_return_books()
        {
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select count(*) from Issue_Book where Return_status ='no'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader re = cmd.ExecuteReader();
                re.Read();
                if (re.HasRows)
                {
                    lblreturn.Text = re[0].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void due_books()
        {
            string date_today = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select count(*) from Issue_Book where Return_status ='no' and Due_Date < '"+ date_today + "' ";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader re = cmd.ExecuteReader();
                re.Read();
                if (re.HasRows)
                {
                    lbldue.Text = re[0].ToString();
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
            this.formSize = this.Size;
            this.Hide();
            Issue_Book ad = new Issue_Book(lblteacher.Text, this.formSize);
            ad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            StudentHistory ad = new StudentHistory(lblteacher.Text, this.formSize);
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            Return_Book ad = new Return_Book(lblteacher.Text, this.formSize);
            ad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            BookReportInventory ad = new BookReportInventory(lblteacher.Text, this.formSize);
            ad.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Issue_book_report ir = new Issue_book_report(lblteacher.Text, this.formSize);
            ir.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            Return_Stats ir = new Return_Stats(lblteacher.Text, this.formSize);
            ir.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            due_books ir = new due_books(lblteacher.Text, this.formSize);
            ir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            Missing_Books ir = new Missing_Books(lblteacher.Text, this.formSize);
            ir.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            Missing_Return_report ir = new Missing_Return_report(lblteacher.Text, this.formSize);
            ir.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.formSize = this.Size;
            this.Hide();
            Discard_book ir = new Discard_book(lblteacher.Text, this.formSize);
            ir.Show();
        }

        private void DashboradTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
