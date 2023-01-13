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
        public Issue_Book(string teacher)
        {
            InitializeComponent();
            lblteacher.Text = teacher.ToString();
            dgvreturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvreturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvissueBK_STD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvissueBK_STD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            check_book_name();
            check_student_name();
            grid_load_Book_Issue_STD();
            grid_load_Book_receive_STD();
        }

        private void check_book_name()
        {

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
                }
                else
                {
                    MessageBox.Show("Book Not add to Inventory. Please add book before Issue.");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : Book ID empty");
            }


        }

        private void check_student_name()
        {

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
                }
                else
                {
                    MessageBox.Show("Student not add to system. Please add before issue book.");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : Student ID empty");
            }


        }

        public void grid_load_Book_Issue_STD()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status from Issue_Book " +
                         " where student_id = '" + txtstdid.Text + "' and Return_status ='no'";
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
                         " where student_id = '" + txtstdid.Text + "' and Return_status ='yes'";
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
                        " values  ('" + bookid + "','" + stdid + "','" + issue + "','" + due + "', 'no'," +
                        " '" + lblteacher.Text + "') ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Issued.");
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
