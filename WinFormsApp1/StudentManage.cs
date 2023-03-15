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
    public partial class StudentManage : Form
    {
        ConString cn = new ConString();
        public StudentManage(string teacher, Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            grid_load_Student();
            refresh_student();
            dgvstudentlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblteacher.Text = teacher;
        }

        public void grid_load_Student()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select * from student";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvstudentlist.DataSource = dta;
            con.Close();
        }

        private void refresh_student()
        {

            txtsid.Text = "";
            txtsname.Text = "";
            dtpsbirth.Text = "";
            txtsgrade.Text = "";
            txtsphone.Text = "";
            txtsaddress.Text = "";
            btnSadd.Enabled = true;
            btnSdelete.Enabled = false;
            btnSupdate.Enabled = false;
            txtsid.Enabled = true;
        }

        private void btnSadd_Click(object sender, EventArgs e)
        {
            string sid = txtsid.Text;
            string name = txtsname.Text;
            string birthdate = dtpsbirth.Value.ToString("yyyy-MM-dd");
            string grade = txtsgrade.Text;
            string phone = txtsphone.Text;
            string address = txtsaddress.Text;
            if (sid != "" && name != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "insert into student (StdID,name,BirthDate,Grade,phone,address)" +
                        " values  ('" + sid + "','" + name + "','" + birthdate + "','" + grade + "', " +
                        " '" + phone + "','" + address + "') ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Student Added success");
                    grid_load_Student();
                    refresh_student();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data insert. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Data Empty in SID , Name. operation fail !");
            }
        }

        private void btnSupdate_Click(object sender, EventArgs e)
        {
            string sid = txtsid.Text;
            string name = txtsname.Text;
            string birthdate = dtpsbirth.Value.ToString("yyyy-MM-dd");
            string grade = txtsgrade.Text;
            string phone = txtsphone.Text;
            string address = txtsaddress.Text;
            if (sid != "" && name != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to UPDATE this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(cn.connectionstring());
                        con.Open();
                        string sql = "update student set name = '" + name + "',birthdate = '" + birthdate + "',grade = '" + grade + "', " +
                            "phone = '" + phone + "',address = '" + address + "'" +
                            " where StdID =  '" + sid + "'";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Student Update success");
                        grid_load_Student();
                        refresh_student();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("invalid data Update. operation fail !");
                    }
                }
                else { }
            }
            else
            {
                MessageBox.Show("Data Empty in ISBN , Name. operation fail !");
            }
        }

        private void btnSdelete_Click(object sender, EventArgs e)
        {
            string sid = txtsid.Text;
            if (sid != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to DELETE this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        SqlConnection con = new SqlConnection(cn.connectionstring());
                        con.Open();
                        string sql = "delete from student where stdid = '" + sid + "' ";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        btnSadd.Enabled = true;
                        btnSdelete.Enabled = false;
                        btnSupdate.Enabled = false;
                        MessageBox.Show("Deleted !");
                        grid_load_Student();
                        refresh_student();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not Delete. operation fail !");
                    }
                }else { }
            }
            else
            {
                MessageBox.Show("Data Empty in SID. operation fail !");
            }
        }

        private void btnSrefresh_Click(object sender, EventArgs e)
        {
            refresh_student();
            grid_load_Student();
        }

        private void btnSidsearch_Click(object sender, EventArgs e)
        {
            string sid = txtsid_search.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select * " +
                    " from student where stdid = '" + sid + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvstudentlist.DataSource = dta;
                con.Close();
                //refresh_book();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void studentSearch_Like()
        {
            string sid = txtsid_search.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select * " +
                    " from student where stdid like '" + sid + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvstudentlist.DataSource = dta;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }
        private void txtsid_search_KeyUp(object sender, KeyEventArgs e)
        {
            studentSearch_Like();
        }

        private void dgvstudentlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtsid.Text = dgvstudentlist.SelectedRows[0].Cells[0].Value.ToString();
                txtsname.Text = dgvstudentlist.SelectedRows[0].Cells[1].Value.ToString();
                dtpsbirth.Text = dgvstudentlist.SelectedRows[0].Cells[2].Value.ToString();
                txtsgrade.Text = dgvstudentlist.SelectedRows[0].Cells[3].Value.ToString();
                txtsphone.Text = dgvstudentlist.SelectedRows[0].Cells[4].Value.ToString();
                txtsaddress.Text = dgvstudentlist.SelectedRows[0].Cells[5].Value.ToString();
                btnSadd.Enabled = false;
                btnSdelete.Enabled = true;
                btnSupdate.Enabled = true;
                txtsid.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("selection error. Please double click row begining column. \n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }
    }
}
