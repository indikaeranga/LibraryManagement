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
    
    public partial class Return_Stats : Form
    {
        ConString cn = new ConString();
        public Return_Stats(string teacher, Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            lblteacher.Text = teacher;
            dgvreturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_load_return_ALL();
        }

        private void btnatr_Click(object sender, EventArgs e)
        {
            grid_load_return_ALL();
        }

        private void grid_load_return_ALL()
        {
            dgvreturn.DataSource = null;
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_Date,Return_status from Issue_Book " +
                         " where Return_status='yes'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvreturn.DataSource = dta;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvreturn.DataSource = null;
            string date_today = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_Date,Return_status " +
                             "from Issue_Book " +
                             " where Return_Date = '" + date_today + "' and Return_status='yes'";
                con.Open();
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
                    MessageBox.Show("No books returned today.");
                    dgvreturn.DataSource = null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : ");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string fromdate = dtpfrom.Value.ToString("yyyy-MM-dd");
            string todate = dtpto.Value.ToString("yyyy-MM-dd");
            dgvreturn.DataSource = null;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_Date,Return_status " +
                             " from Issue_Book " +
                             " where Return_Date between '" + fromdate + "' and '" + todate + "' and Return_status='yes'";
                con.Open();
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
                    MessageBox.Show("No books returned on given date period.");
                    dgvreturn.DataSource = null;
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
    }
}
