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
    public partial class Missing_Return_report : Form
    {
        ConString cn = new ConString();
        public Missing_Return_report(string teacher, Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            lblteacher.Text = teacher;
            load_all_missing();
            dgvall.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void load_all_missing()
        {
            dgvall.DataSource = null;
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select ib.Book_ID,ib.Student_ID, mb.Date , mb.Pay_Replace , mb.Price, mb.Remark  " +
                             " from Issue_Book ib join  " +
                             " Mising_books mb on " +
                         " ib.Issue_ID = mb.Issue_ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvall.DataSource = dta;
            con.Close();
        }
        private void btnall_Click(object sender, EventArgs e)
        {
            load_all_missing();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }
    }
}
