using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminDashboard : Form
    {
        ConString cn = new ConString();
        public AdminDashboard()
        {
            InitializeComponent();
            grid_load_teacher();
            grid_load_rack();
            book_category_refresh();
            rack_refresh();
            refreshbtns_teacher();
            grid_load_book_cat();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private int admin_radiobtn_value() { 
            int rbvalue = 0;
            if ( rbadmin.Checked == true ) 
            { rbvalue = 1; }
            else if(rbteacher.Checked == true){
                rbvalue = 0;
            }
            else 
            { rbvalue = 0; }
            return rbvalue; 
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            int rbvalue = admin_radiobtn_value(); // teacher or admin 

            if (txtnic.Text != "" && txtname.Text != "" && txtpass.Text != "" )
            {
                
                try
                {

                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "insert into Teacher_Admin (nic,name,password,phone,address,access) values  ('" + txtnic.Text + "','" + txtname.Text + "','" + txtpass.Text + "','" + txtphone.Text + "' "+
                        ", '" + txtaddress.Text + "'," + rbvalue + ") ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    empty_box_teacher();
                    grid_load_teacher();
                    MessageBox.Show("Data Added success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data insert. operation fail !");
                    empty_box_teacher();
                }
            }
            else
            {
                MessageBox.Show("Data Empty in nic , name or password. operation fail !");
            }
        }
        public void grid_load_teacher()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select * from Teacher_Admin";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvTeacher.DataSource = dta;
            con.Close();
        }

        private void empty_box_teacher() {
            txtnic.Text = "";
            txtname.Text = "";
            txtpass.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
            rbteacher.Checked = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int rbvalue = admin_radiobtn_value();
            if (txtnic.Text != "" && txtname.Text != "" && txtpass.Text != "")
            {
                try
                {

                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "update Teacher_Admin set "+
                        "nic = '"+txtnic.Text+"', "+
                        "name = '" + txtname.Text + "' , password = '" + txtpass.Text + "' ,"+
                        "phone = '" + txtphone.Text + "' , access = '"+rbvalue +"' "+
                        " where id = '"+dgvTeacher.SelectedRows[0].Cells[0].Value.ToString()+"' ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    empty_box_teacher();
                    grid_load_teacher();
                    btnadd.Enabled = true;
                    btndelete.Enabled = false;
                    btnupdate.Enabled = false;
                    MessageBox.Show("Update success");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("invalid update. operation fail !");
                    empty_box_teacher();
                }
            }
            else
            {
                MessageBox.Show("Data Empty in nic , name or password. operation fail !");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtnic.Text != "" )
            {
                try
                {

                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "delete from Teacher_Admin where id = '" + dgvTeacher.SelectedRows[0].Cells[0].Value.ToString() + "' ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    empty_box_teacher();
                    grid_load_teacher();
                    btnadd.Enabled = true;
                    btndelete.Enabled = false;
                    btnupdate.Enabled = false;
                    MessageBox.Show("Deleted !");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Not Delete. operation fail !");
                    empty_box_teacher();
                }
            }
            else
            {
                MessageBox.Show("Data Empty in nic. operation fail !");
            }
        }

        private void dgvTeacher_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtnic.Text = dgvTeacher.SelectedRows[0].Cells[1].Value.ToString();
                txtname.Text = dgvTeacher.SelectedRows[0].Cells[2].Value.ToString();
                txtpass.Text = dgvTeacher.SelectedRows[0].Cells[3].Value.ToString();
                txtphone.Text = dgvTeacher.SelectedRows[0].Cells[4].Value.ToString();
                txtaddress.Text = dgvTeacher.SelectedRows[0].Cells[5].Value.ToString();
                btnadd.Enabled = false;
                btndelete.Enabled = true;
                btnupdate.Enabled = true;               
                int intval = Convert.ToInt16(dgvTeacher.SelectedRows[0].Cells[6].Value.ToString()); 
                if (intval == 1) { rbadmin.Checked = true; }
                else { rbteacher.Checked = true; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("selection error. Please double click row begining column. \n");
            }
        }

        private void refreshbtns_teacher()
        {
            btnadd.Enabled = true;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshbtns_teacher();
            empty_box_teacher();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnaddR_Click(object sender, EventArgs e)
        {
            if (txtrid.Text != "" && txtrname.Text != "")
            {
                try
                {

                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "insert into rack (Rack_Name_ID,Remark) values  ('" + txtrid.Text + "','" + txtrname.Text + "') ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    grid_load_rack();
                    rack_refresh();
                    MessageBox.Show("Rack Add success");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("invalid data insert. operation fail !");
                    rack_refresh();
                }
            }
            else
            {
                MessageBox.Show("Data Empty in Rack ID , name operation fail !");
            }
        }

        public void grid_load_rack()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select * from rack order by Rack_Name_ID ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvrack.DataSource = dta;
            con.Close();
        }

        private void btnupdateR_Click(object sender, EventArgs e)
        {
            if (txtrid.Text != "" && txtrname.Text != "")
            {
                try
                {

                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "update rack set " +
                        "Rack_Name_ID = '" + txtrid.Text + "' ,Remark= '" + txtrname.Text+"' "+
                        "where id = '"+ dgvrack.SelectedRows[0].Cells[0].Value.ToString() + "'";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    grid_load_rack();
                    rack_refresh();
                    MessageBox.Show("Rack update success");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("invalid update. operation fail !");
                    rack_refresh();
                }
            }
            else
            {
                MessageBox.Show("Data Empty in Rack ID  or Name. operation fail !");
            }
        }

        private void btnrefreshR_Click(object sender, EventArgs e)
        {
            rack_refresh();
        }

        private void rack_refresh()
        {
            btnaddR.Enabled = true;
            btnupdateR.Enabled = false;
            btnDeleteR.Enabled = false;
            txtrid.Text = "";
            txtrname.Text = "";
        }
        private void book_category_refresh()
        {
            btnbcadd.Enabled = true;
            btnbcUpdate.Enabled = false;
            btnbcDel.Enabled = false;
            txtcatname.Text = "";
            txtcatremark.Text = "";
        }



        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(cn.connectionstring());
                con.Open();
                string sql = "delete rack " +
                    "where id = '" + dgvrack.SelectedRows[0].Cells[0].Value.ToString() + "'";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_load_rack();
                rack_refresh();
                MessageBox.Show("Rack Delete success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid Delete. operation fail !");
                rack_refresh(); ;
            }
        }

        private void dgvrack_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtrid.Text = dgvrack.SelectedRows[0].Cells[1].Value.ToString();
                txtrname.Text = dgvrack.SelectedRows[0].Cells[2].Value.ToString();
                btnaddR.Enabled = false;
                btnDeleteR.Enabled = true;
                btnupdateR.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("selection error. Please double click row begining column. \n");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public void grid_load_book_cat()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select * from Book_Category";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvbookcat.DataSource = dta;
            con.Close();
        }
        private void btnbcadd_Click(object sender, EventArgs e)
        {
            if (txtcatname.Text != "" && txtcatremark.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "insert into book_category (Category_Name_ID,remark) values  ('" + txtcatname.Text + "','" + txtcatremark.Text + "') ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    book_category_refresh();
                    grid_load_book_cat();
                    MessageBox.Show("Book Category Add success");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("invalid data insert. operation fail !");
                    book_category_refresh();
                }
            }
            else
            {
                MessageBox.Show("Data Empty in name. operation fail !");
                book_category_refresh();
            }
        }

        private void Btnbcrefresh_Click(object sender, EventArgs e)
        {
            book_category_refresh();
        }

        private void btnbcUpdate_Click(object sender, EventArgs e)
        {
            if (txtcatname.Text != "" && txtcatremark.Text != "")
            {
                try
                {

                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "update Book_category set " +
                        "Category_Name_ID = '" + txtcatname.Text + "' , remark= '" + txtcatremark.Text + "' " +
                        "where id = '" + dgvbookcat.SelectedRows[0].Cells[0].Value.ToString() + "'";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    grid_load_book_cat();
                    book_category_refresh();
                    MessageBox.Show("Book Category update success");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("invalid update. operation fail !");
                    book_category_refresh();
                }
            }
            else
            {
                MessageBox.Show("Data Empty in Category Name. operation fail !");
            }
        }

        private void dgvbookcat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtcatname.Text = dgvbookcat.SelectedRows[0].Cells[1].Value.ToString();
                txtcatremark.Text = dgvbookcat.SelectedRows[0].Cells[2].Value.ToString();
                btnbcadd.Enabled = false;
                btnbcUpdate.Enabled = true;
                btnbcDel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("selection error. Please double click row begining column. \n");
            }
        }

        private void btnbcDel_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(cn.connectionstring());
                con.Open();
                string sql = "delete Book_category " +
                    "where id = '" + dgvbookcat.SelectedRows[0].Cells[0].Value.ToString() + "'";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_load_book_cat();
                book_category_refresh();
                MessageBox.Show("Book_category Delete success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid Delete. operation fail !");
                rack_refresh(); ;
            }
        }
    }
}
