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
    public partial class BookReportInventory : Form
    {
        ConString cn = new ConString();
        public BookReportInventory(string teacher, Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            lblteacher.Text = teacher.ToString();
            dgvISBN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid_load_ISBN_ALL();
        }

        private void grid_load_ISBN_ALL()
        {
            dgvISBN.DataSource = null;
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select * from book";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvISBN.DataSource = dta;
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvISBN.DataSource = null;
            string date_today = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select * from book " +
                             " where Date = '" + date_today + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvISBN.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("ISBN not registered to system today.");
                    dgvISBN.DataSource=null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : ");
            }
        }

        private void btnsearchisbn_Click(object sender, EventArgs e)
        {
            dgvISBN.DataSource = null;
            string isbn = txtisbn.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select * from book " +
                             " where isbn = '" + isbn + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvISBN.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("ISBN not registered to system today.");
                    dgvISBN.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : ");
            }
        }

        private void btnisbndatesearch_Click(object sender, EventArgs e)
        {
            string fromdate = dtpfromsibn.Value.ToString("yyyy-MM-dd");
            string todate = dtptoisbn.Value.ToString("yyyy-MM-dd");
            dgvISBN.DataSource = null;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select * from book " +
                             " where Date between '" + fromdate + "' and '" + todate + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvISBN.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("ISBN not registered to system on given date period.");
                    dgvISBN.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : ");
            }
        }

        private void btnallbooks_Click(object sender, EventArgs e)
        {
            dgvISBN.DataSource = null;
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select bi.Book_ID, b.Name, b.ISBN,  bi.Rack, b.First_Publish  as 'First Publish', "+
                         " bi.Publish_Date as 'This Edition Publish', " +
                         " bi.Take_Method,bi.Price,bi.Teacher,bi.Quantity "+
                         " from Book b inner join Book_Inventory bi on b.ISBN = bi.ISBN ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvISBN.DataSource = dta;
            con.Close();
        }

        private void btntodayaddinv_Click(object sender, EventArgs e)
        {
            dgvISBN.DataSource = null;
            string date_today = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select bi.Book_ID, b.Name, b.ISBN,  bi.Rack, b.First_Publish  as 'First Publish', " +
                         " bi.Publish_Date as 'This Edition Publish', " +
                         " bi.Take_Method,bi.Price,bi.Teacher,bi.Quantity " +
                         " from Book b inner join Book_Inventory bi on b.ISBN = bi.ISBN " +
                         " where bi.Date = '" + date_today + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvISBN.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("Not Added books to the system today.");
                    dgvISBN.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex);
            }
        }

        private void btnbookidsearch_Click(object sender, EventArgs e)
        {
            dgvISBN.DataSource = null;
            string id = txtbookid.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select bi.Book_ID, b.Name, b.ISBN,  bi.Rack, b.First_Publish  as 'First Publish', " +
                         " bi.Publish_Date as 'This Edition Publish', " +
                         " bi.Take_Method,bi.Price,bi.Teacher,bi.Quantity " +
                         " from Book b inner join Book_Inventory bi on b.ISBN = bi.ISBN " +
                         " where bi.Book_ID = '" + id + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvISBN.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("ISBN not registered to system today.");
                    dgvISBN.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : ");
            }
        }

        private void btnbookkdatesearch_Click(object sender, EventArgs e)
        {
            string fromdate = dtpbookfrom.Value.ToString("yyyy-MM-dd");
            string todate = dtpbookto.Value.ToString("yyyy-MM-dd");
            dgvISBN.DataSource = null;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select bi.Book_ID, b.Name, b.ISBN,  bi.Rack, b.First_Publish  as 'First Publish', " +
                         " bi.Publish_Date as 'This Edition Publish', " +
                         " bi.Take_Method,bi.Price,bi.Teacher,bi.Quantity " +
                         " from Book b inner join Book_Inventory bi on b.ISBN = bi.ISBN " +
                         " where bi.Date between '" + fromdate + "' and '" + todate + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvISBN.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("ISBN not registered to system on given date period.");
                    dgvISBN.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : ");
            }
        }
    }
}
