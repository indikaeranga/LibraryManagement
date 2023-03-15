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
    public partial class Missing_Books : Form
    {
        ConString cn = new ConString();
        public Missing_Books(string teacher,Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            lblteacher.Text = teacher;
            dgvreturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshbtn();
        }
        private void refreshbtn()
        {
            dgvreturn.DataSource = null;
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select ib.Issue_ID,ib.Book_ID,lb.Name,ib.Student_ID,ib.Issue_Date,ib.Due_Date,ib.Return_status " +
                             " from Issue_Book ib join Book_Inventory b on " +
                             " b.Book_ID = ib.Book_ID join Book lb on lb.ISBN = b.ISBN " +
                         " where ib.Return_status ='no'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvreturn.DataSource = dta;
            con.Close();
            txtstdit.Text = "";
            txtbookidsearch.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            searchbtn();
        }
        private void searchbtn()
        {
            string stdid = txtstdit.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                con.Open();
                string sql = "select ib.Issue_ID,ib.Book_ID,lb.Name,ib.Student_ID,ib.Issue_Date,ib.Due_Date,ib.Return_status " +
                             " from Issue_Book ib join Book_Inventory b on " +
                             " b.Book_ID = ib.Book_ID join Book lb on lb.ISBN = b.ISBN " +
                             " where ib.student_id = '" + txtstdit.Text + "' and ib.Return_status ='no'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvreturn.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("No books in the system with given details.");
                    dgvreturn.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : Student ID empty.");
            }
        }

        private void btnsearchbybookid_Click(object sender, EventArgs e)
        {
            string bookid = txtbookidsearch.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                con.Open();
                string sql = "select ib.Issue_ID,ib.Book_ID,lb.Name,ib.Student_ID,ib.Issue_Date,ib.Due_Date,ib.Return_status " +
                             " from Issue_Book ib join Book_Inventory b on " +
                             " b.Book_ID = ib.Book_ID join Book lb on lb.ISBN = b.ISBN " +
                             " where ib.Book_ID = '" + bookid + "' and ib.Return_status ='no'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvreturn.DataSource = dta;
                    DataRow row = dta.Rows[0];
                    lblissue.Text = row[0].ToString();
                    lblbookid.Text = row[1].ToString();
                    lblstdid.Text = row[3].ToString();

                }
                else
                {
                    MessageBox.Show("No books in the system with given details.");
                    dgvreturn.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : BOOK ID empty.");
            }
        }

        private void dgvreturn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                lblissue.Text = dgvreturn.SelectedRows[0].Cells[0].Value.ToString();
                lblbookid.Text = dgvreturn.SelectedRows[0].Cells[1].Value.ToString();
                lblstdid.Text = dgvreturn.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("selection error. Please double click row begining column. \n");
            }
        }

        private string Book_Inv_radiobtn_value()
        {
            string rbvalue = "";
            if (rdbpay.Checked == true)
            { rbvalue = "Pay"; }
            else if (rdbrep.Checked == true)
            { rbvalue = "Replace"; }
            return rbvalue;
        }



        private void btnsubmit_Click(object sender, EventArgs e)
        {
            btnMiss_submit();
            refreshbtn();
        }
        private void btnMiss_submit()
        {
            string issueid = lblissue.Text;
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string pay_replcae = Book_Inv_radiobtn_value(); // Pay or Replace
            string remark = txtremark.Text;
            double price = 0;
            if (txtprice.Text == null || txtprice.Text == "") { price = 0; }
            else { price = Convert.ToDouble(txtprice.Text); }


            if (issueid != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "insert into Mising_books (Issue_ID,Pay_Replace,Price,Remark,Date)" +
                        " values  ('" + issueid + "','" + pay_replcae + "','" + price + "', " +
                        " '" + remark + "','" + today + "') ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    miss_replace_Issue_Table(); //add MR in return status in issue_book table 
                    MessageBox.Show("Missing Book Added to Missing Inventory success");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data insert. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Docble click the grid if data have. If not data not available for update !");
            }
        }
        private void miss_replace_Issue_Table() //add MR in return status in issue_book table 
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string issueid = lblissue.Text; ;
            if (issueid != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "update Issue_Book set Return_status = 'MR' , Return_Date = '" + today + "', " +
                                 " Return_teacher = '" + lblteacher.Text + "' where Issue_ID = '" + issueid + "' ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data Update. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Data Empty in Book ID. operation fail !");
            }
        }
    }
}
