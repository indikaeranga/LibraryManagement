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
    public partial class Discard_book : Form
    {
        ConString cn = new ConString();
        public Discard_book(string teacher, Size formSize)
        {
            InitializeComponent();
            this.Size = formSize;
            lblteacher.Text = teacher;
            grid_load_book_discard();
        }

        private void btnbookid_Click(object sender, EventArgs e)
        {
            if (txtbookid.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    string sql = " select bi.Book_ID,bi.ISBN ,b.Name, b.Author from " +
                                 " Book_Inventory bi join Book b on bi.ISBN = b.ISBN " +
                                 " where bi.Book_ID =  '" + txtbookid.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dta = new DataTable();
                    da.Fill(dta);
                    if (dta.Rows.Count > 0)
                    {
                        DataRow row = dta.Rows[0];
                        lblbi.Text = row[0].ToString();
                        lblisbn.Text = row[1].ToString();
                        lblbn.Text = row[2].ToString();
                        lblauthor.Text = row[3].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Book on given Book ID");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error : Book ID empty");
                }
            }
            else {
                MessageBox.Show("error : Book ID empty");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }

        private void btndiscard_Click(object sender, EventArgs e)
        {
            if (txtbookid.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to DISCARD this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        SqlConnection con = new SqlConnection(cn.connectionstring());
                        con.Open();
                        string sql = "delete from Book_Inventory where Book_ID = '" + txtbookid.Text + "' ";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        btndiscard.Enabled = false;
                        MessageBox.Show("Discarded !");
                        deisacrd_tbl_add();
                        grid_load_book_discard();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Not Discarded. operation fail !");
                    }
                }
                else { }
            }
            else
            {
                MessageBox.Show("Data Empty in Book ID. operation fail !");
            }
        }

        private void deisacrd_tbl_add()
        {
            
            string date_today = DateTime.Now.ToString("yyyy-MM-dd");
            string bookno = lblbi.Text;
            string bookisbn = lblisbn.Text;
            string teacher = lblteacher.Text;
            string reason = txtreason.Text;

            if (bookno != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "insert into Discard_Books (Book_ID,isbn,Teacher,D_date,Description)" +
                        " values  ('" + bookno + "','" + bookisbn + "','" + teacher + "','" + date_today + "', '" + reason + "') ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("Discard_Book success");
                }
                catch (Exception ex)
                {
                   // MessageBox.Show("invalid data insert. operation fail !");
                }
            }
            else
            {
                //MessageBox.Show("Data Empty operation fail !");
            }
        }

        public void grid_load_book_discard()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select  Book_ID,ISBN,Teacher,D_Date,Description from Discard_Books";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvdiscard.DataSource = dta;
            con.Close();
        }
    }
}
