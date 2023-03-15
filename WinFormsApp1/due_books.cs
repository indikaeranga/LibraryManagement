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
    public partial class due_books : Form
    {
        ConString cn = new ConString();
        public due_books(string teacher, Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            lblteacher.Text = teacher;
            dgvdue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_load_due_ALL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid_load_due_ALL();
        }

        private void grid_load_due_ALL()
        {
            string date_today = DateTime.Now.ToString("yyyy-MM-dd");
            dgvdue.DataSource = null;
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status from Issue_Book " +
                         " where Return_status='no' and Due_Date < '"+ date_today + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvdue.DataSource = dta;
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }
    }
}
