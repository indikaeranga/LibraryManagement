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
    public partial class Issue_book_report : Form
    {
        ConString cn = new ConString();
        public Issue_book_report(string teacher, Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            lblteacher.Text = teacher;
            history_all();
            dgvissued.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid_load_issued_ALL();
        }

        private void grid_load_issued_ALL()
        {
            dgvissued.DataSource = null;
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status from Issue_Book "+
                         " where Return_status='no'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvissued.DataSource = dta;
            con.Close();
        }

        private void btntoday_Click(object sender, EventArgs e)
        {
            dgvissued.DataSource = null;
            string date_today = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status "+
                             "from Issue_Book " +
                             " where Issue_Date = '" + date_today + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvissued.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("No books issued today.");
                    dgvissued.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : ");
            }
        }

        private void btndatesearch_Click(object sender, EventArgs e)
        {
            string fromdate = dtpfrom.Value.ToString("yyyy-MM-dd");
            string todate = btnto.Value.ToString("yyyy-MM-dd");
            dgvissued.DataSource = null;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status "+
                             " from Issue_Book " +
                             " where Issue_Date between '" + fromdate + "' and '" + todate + "' and Return_status='no'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    dgvissued.DataSource = dta;
                }
                else
                {
                    MessageBox.Show("No books issued on given date period.");
                    dgvissued.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : ");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            history_all();
        }

        private void history_all()
        {
            dgvissued.DataSource = null;
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status from Issue_Book order by Issue_ID desc";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvissued.DataSource = dta;
            con.Close();


        }
    }
}
