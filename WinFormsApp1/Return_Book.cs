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
    public partial class Return_Book : Form
    {
        ConString cn = new ConString();
        public Return_Book(string teacher,Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            refreshbtn();
            lblteacher.Text = teacher.ToString();
            dgvreturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            string returndate = dtpreturnbybookid.Value.ToString("yyyy-MM-dd");
            string issueid = txtissue.Text;
            if (issueid != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "update Issue_Book set Return_status = 'yes' , Return_Date = '" + returndate + "', "+
                                 " Return_teacher = '"+lblteacher.Text+ "' where Issue_ID = '" + issueid + "' ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dta = new DataTable();
                    da.Fill(dta);
                    dgvreturn.DataSource = dta;
                    con.Close();
                    MessageBox.Show("Success !");
                    refreshbtn();
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

        private void label2_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            searchbtn();
        }

        private void searchbtn() {
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
                txtbook.Enabled = false;
                txtissue.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : Student ID empty.");
            }
        }

        private void dgvreturn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtissue.Text = dgvreturn.SelectedRows[0].Cells[0].Value.ToString();
                txtbook.Text = dgvreturn.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("selection error. Please double click row begining column. \n");
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            string returndate = dtpreturn.Value.ToString("yyyy-MM-dd");
            string issueid = txtissue.Text;
            if (issueid != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "update Issue_Book set Return_status = 'yes' , Return_Date = '" + returndate + "', " +
                                 " Return_teacher = '" + lblteacher.Text + "' where Issue_ID = '" + issueid + "' ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dta = new DataTable();
                    da.Fill(dta);
                    dgvreturn.DataSource = dta;
                    con.Close();
                    MessageBox.Show("Success !");
                    refreshbtn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data Update. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Data Empty in Issued ID. operation fail !");
            }
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
            //txtbook.Enabled = true;
            //txtissue.Enabled = true;
            txtbook.Text = "";
            txtissue.Text = "";
            txtstdit.Text = "";
            txtbookidsearch.Text = "";

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
                    txtissue.Text = row[0].ToString();
                    txtbook.Text = row[1].ToString();                  
                }
                else
                {
                    MessageBox.Show("No books in the system with given details.");
                    dgvreturn.DataSource = null;
                }
                con.Close();
                txtbook.Enabled = false;
                txtissue.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : BOOK ID empty.");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
