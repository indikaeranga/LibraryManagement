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
    public partial class StudentHistory : Form
    {
        ConString cn = new ConString();
        public StudentHistory(string teacher)
        {
            InitializeComponent();
            lblteacher.Text = teacher.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            grid_load_Book_Issue_STD();
            grid_load_Book_receive_STD();
            check_student_name();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
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
            dgvhandover.DataSource = dta;
            con.Close();
        }
        public void grid_load_Book_receive_STD()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status from Issue_Book " +
                         " where student_id = '" + txtstdid.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvall.DataSource = dta;
            con.Close();
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
                    lblstudent.Text = "";
                    MessageBox.Show("Student not add to system. Please add before issue book.");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : Student ID empty");
            }


        }
    }
}
