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
        public Return_Book(string teacher)
        {
            InitializeComponent();
            lblteacher.Text = teacher.ToString();
            dgvreturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvreturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            string returndate = dtpreturnbybookid.Value.ToString("yyyy-MM-dd");
            string bookid = txtbook.Text;
            if (bookid != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "update Issue_Book set Return_status = 'yes' , Return_Date = '" + returndate + "', "+
                                 " Return_teacher = '"+lblteacher.Text+ "' where Book_ID = '"+bookid+"' ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Accepted !");
                    searchbtn();
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
                string sql = "select Issue_ID,Book_ID,Student_ID,Issue_Date,Due_Date,Return_status from Issue_Book " +
                             " where student_id = '" + txtstdit.Text + "' and Return_status ='no'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvreturn.DataSource = dta;
                con.Close();
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
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Accepted !");
                    searchbtn();
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
    }
}
