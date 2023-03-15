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
    public partial class Issue_Book : Form
    {
        ConString cn = new ConString();
        public Issue_Book(string teacher, Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            lblteacher.Text = teacher.ToString();
            dgvreturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;           
            dgvissueBK_STD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnissue.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if (check_book_name() == 1 && check_student_name() ==1) { btnissue.Enabled = true; }
            


            grid_load_Book_Issue_STD();
            grid_load_Book_receive_STD();
        }

        private int check_book_name()
        {
            int number;
            string bookid = txtbookid.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select b.name from Book b INNER JOIN Book_Inventory i on b.ISBN = i.ISBN "+
                             " where i.book_id = '" + bookid + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    DataRow row = dta.Rows[0];
                    lblBook.Text = row[0].ToString();
                     number = 1;
                }
                else
                {
                    MessageBox.Show("Invalid Book ID or Not add to Inventory. Please add book before Issue.");
                    btnissue.Enabled = false;
                    lblstudent.Text = "";
                    lblBook.Text = "";
                    number = 0;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : Book ID empty");
                btnissue.Enabled = false;
                lblstudent.Text = "";
                lblBook.Text = "";
                number = 0;
            }
            return number;

        }

        private int check_student_name()
        {
            int number;
            string stdid = txtstdid.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select name from student " +
                             " where stdid = '" + stdid + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    DataRow row = dta.Rows[0];
                    lblstudent.Text = row[0].ToString();
                    number = 1;
                }
                else
                {
                    MessageBox.Show("Invalid Student ID or not add to system. Please add before issue book.");
                    btnissue.Enabled = false;
                    lblstudent.Text = "";
                    lblBook.Text = "";
                    number = 0;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : Student ID empty");
                btnissue.Enabled = false;
                lblstudent.Text = "";
                lblBook.Text = "";
                number = 0;
            }
            return number;

        }

        public void grid_load_Book_Issue_STD()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status from Issue_Book " +
                         " where student_id = '" + txtstdid.Text + "' and Return_status ='NO'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvissueBK_STD.DataSource = dta;
            con.Close();
        }

        public void grid_load_Book_receive_STD()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status from Issue_Book " +
                         " where student_id = '" + txtstdid.Text + "' and Return_status ='YES'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvreturn.DataSource = dta;
            con.Close();
        }

        private void btnissue_Click(object sender, EventArgs e)
        {
            string bookid = txtbookid.Text;
            string stdid = txtstdid.Text;
            string issue = dtpissue.Value.ToString("yyyy-MM-dd");
            string due = dtpdue.Value.ToString("yyyy-MM-dd");
            if (bookid != "" && stdid != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "insert into Issue_Book (Book_ID,Student_ID,Issue_Date,Due_Date,Return_status,Issue_teacher)" +
                        " values  ('" + bookid + "','" + stdid + "','" + issue + "','" + due + "', 'NO'," +
                        " '" + lblteacher.Text + "') ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Issued.");
                    btnissue.Enabled = false;
                    //lblstudent.Text = "";
                    lblBook.Text = "";
                    txtbookid.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data insert. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Data Empty in Student ID or Book ID. operation fail !");
            }
        }
    }
}
