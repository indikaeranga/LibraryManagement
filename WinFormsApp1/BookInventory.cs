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
    public partial class BookInventory : Form
    {
        ConString cn = new ConString();
        
        public BookInventory( String TeacherName)
        {
            InitializeComponent();
            grid_load_Book();
            cmBI_rack_load();
            grid_load_book_Inventory();
            lblteacher.Text = TeacherName.ToString();
            refresh_book();
            dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookInv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtpages_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void grid_load_Book()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select * from Book";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvBook.DataSource = dta;
            con.Close();
        }

        

        public void grid_load_book_Inventory()
        {
            SqlConnection con = new SqlConnection(cn.connectionstring());
            con.Open();
            string sql = "select * from Book_Inventory";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            da.Fill(dta);
            dgvBookInv.DataSource = dta;
            con.Close();
        }

        private void refresh_book()
        {
            txtBisbn.Text = "";
            txtBname.Text = "";
            txtBauthor.Text = "";
            txtBdescription.Text = "";
            txtBpublish.Text = "";
            txtBpages.Text = "";
            txtBprint.Text = "";
            dtp1stpublish.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtBisbn.Enabled = true;
            btnBadd.Enabled = true;
            btnBdelete.Enabled = false;
            btnBupdate.Enabled = false;
            txtBsearch.Text = "";

        }

       
        private void btnBadd_Click(object sender, EventArgs e)
        {
            
            string firststpublish = dtp1stpublish.Value.ToString("yyyy-MM-dd");
            string date_today = DateTime.Now.ToString("yyyy-MM-dd");
            string publisher = txtBpublish.Text;
            int pages = Int32.Parse(txtBpages.Text);
            string printing  = txtBprint.Text;
            if (txtBisbn.Text != "" && txtBname.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "insert into Book (isbn,name,author,description,date,teacher,First_Publish,Publisher,pages,printing)"+
                        " values  ('" + txtBisbn.Text + "','" + txtBname.Text + "','" + txtBauthor.Text + "','" + txtBdescription.Text + "' " +
                        ", '" + date_today + "','" + lblteacher.Text + "','" + firststpublish + "','" + publisher + "', "+
                        " " + pages + ", '" + printing + "') ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Added success");
                    grid_load_Book();
                    refresh_book();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data insert. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Data Empty in ISBN , Name. operation fail !");
            } 
        }

        private void txtBpages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBrefresh_Click(object sender, EventArgs e)
        {
            grid_load_Book();
            refresh_book();
        }

        private void btnBupdate_Click(object sender, EventArgs e)
        {
            string ISBN = txtBisbn.Text;
            string name = txtBname.Text;
            string author = txtBauthor.Text;
            string desc = txtBdescription.Text;
            string firststpublish = dtp1stpublish.Value.ToString("yyyy-MM-dd");
            string date_today = DateTime.Now.ToString("yyyy-MM-dd");
            string publisher = txtBpublish.Text;
            int pages = Int32.Parse(txtBpages.Text);
            string printing = txtBprint.Text;
            if (txtBisbn.Text != "" && txtBname.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "update Book set name = '"+ name + "',author = '" + author + "',description = '" + desc + "', "+
                        "First_Publish = '" + firststpublish + "',Publisher = '" + publisher + "' ,pages = '" + pages + "',"+
                        "printing = '" + printing + "'" +
                        " where ISBN =  '" + ISBN + "'";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Update success");
                    grid_load_Book();
                    refresh_book();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data Update. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Data Empty in ISBN , Name. operation fail !");
            }
        }

        private void dgvBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtBisbn.Text = dgvBook.SelectedRows[0].Cells[0].Value.ToString();
                txtBname.Text = dgvBook.SelectedRows[0].Cells[1].Value.ToString();
                txtBauthor.Text = dgvBook.SelectedRows[0].Cells[2].Value.ToString();
                txtBdescription.Text = dgvBook.SelectedRows[0].Cells[3].Value.ToString();
                dtp1stpublish.Text = dgvBook.SelectedRows[0].Cells[6].Value.ToString();
                txtBpublish.Text = dgvBook.SelectedRows[0].Cells[7].Value.ToString();
                txtBpages.Text = dgvBook.SelectedRows[0].Cells[8].Value.ToString();
                txtBprint.Text = dgvBook.SelectedRows[0].Cells[9].Value.ToString();
                btnBadd.Enabled = false;
                btnBdelete.Enabled = true;
                btnBupdate.Enabled = true;
                txtBisbn.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("selection error. Please double click row begining column. \n");
            }
        }

        private void btnBdelete_Click(object sender, EventArgs e)
        {
            if (txtBisbn.Text != "")
            {
                try
                {

                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "delete from book where ISBN = '" + dgvBook.SelectedRows[0].Cells[0].Value.ToString() + "' ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    btnBadd.Enabled = true;
                    btnBdelete.Enabled = false;
                    btnBupdate.Enabled = false;
                    MessageBox.Show("Deleted !");
                    grid_load_Book();
                    refresh_book();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Delete. operation fail !");                   
                }
            }
            else
            {
                MessageBox.Show("Data Empty in ISBN. operation fail !");
            }
        }

        private void btnBsearch_Click(object sender, EventArgs e)
        {
            string isbn = txtBsearch.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select isbn,name,author,description,date,teacher,First_Publish,Publisher,pages,printing " +
                    " from book where isbn = '" + isbn + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvBook.DataSource = dta;
                con.Close();
                refresh_book();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void isbnBookSearch_Like()
        {
            string isbn = txtBsearch.Text;           
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select isbn,name,author,description,date,teacher,First_Publish,Publisher,pages,printing " +
                    " from book where isbn like '" + isbn + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvBook.DataSource = dta;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void txtBsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBsearch_KeyUp(object sender, KeyEventArgs e)
        {
            isbnBookSearch_Like();
            btnBdelete.Enabled = false;
            btnBupdate.Enabled = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnSadd_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvstudentlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnSrefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSupdate_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSdelete_Click(object sender, EventArgs e)
        {
           
        }

        public void cmBI_rack_load()   //load Rack combo box in book inventory tab
        {
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                con.Open();
                string sql = "select Rack_Name_ID from rack";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                cmBIrack.DisplayMember = "Rack_Name_ID";
                //cmBIrack.ValueMember = "Rack_Name_ID";
                cmBIrack.DataSource = dta;
                cmBIrack.SelectedIndex = -1;
                con.Close();
            }catch (Exception ex) {
            
                MessageBox.Show("Rack selection error please select again");
            }
        }
        private int Book_Inv_radiobtn_value()
        {
            int rbBIvalue = 1;
            if (rbBIbuy.Checked == true)
            { rbBIvalue = 1; }
            else if (rbBIdonate.Checked == true)
            {
                rbBIvalue = 2;
            }
            else if (rbBIgov.Checked == true)
            { rbBIvalue = 3; }
            return rbBIvalue;
        }


        private int cmbBox_select_check_Rack()
        {
            int rack = 0;
            if (cmBIrack.SelectedIndex == -1 || cmBIrack.Text == "") { rack = 0; }
            else { rack = 1; }
            return rack;
        }
        private void btnBIadd_Click(object sender, EventArgs e)
        {
            if (check_isbn_book_inv() == 0) {  }
            else if (cmbBox_select_check_Rack() == 0) { MessageBox.Show("Rack should Be select. not just type."); }
            else { btnBI_Add_New(); }
        }

        private void btnBI_Add_New()
        {

            string Book_ID = txtBIbookid.Text;
            string isbn = txtBInvISBN.Text;
            string rack = cmBIrack.Text;
            string Publish_Date = dtpBIpublishdate.Value.ToString("yyyy-MM-dd");
            int rbBIvalue = Book_Inv_radiobtn_value(); // buy,donate or government
            double price = 0;
            if(txtBIprice.Text == null || txtBIprice.Text == "") { price = 0; }  
            else { price = Convert.ToDouble(txtBIprice.Text);  }
            int quantity = 0;
            if (txtBIquantity.Text == null || txtBIquantity.Text == "") { quantity = 1; }
            else { quantity = Convert.ToInt32(txtBIquantity.Text); }
            string teacher = lblteacher.Text;
            if (Book_ID != "" && isbn != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "insert into Book_Inventory (Book_ID,isbn,rack,Publish_Date,Take_Method,price,Quantity,teacher)" +
                        " values  ('" + Book_ID + "','" + isbn + "','" + rack + "','" + Publish_Date + "', " +
                        " '" + rbBIvalue + "','" + price + "','" + quantity + "','" + teacher + "') ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Added to Inventory success");
                    grid_load_book_Inventory();
                    book_inventory_refreshbtn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data insert. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Book ID Should be unique. Please check for same Book ID exists. operation fail !");
            }
        }

        private void btnBIupdate_Click(object sender, EventArgs e)
        {
            if (cmbBox_select_check_Rack() == 0) { MessageBox.Show("Rack should Be select. not just type."); }
            else { book_inv_update(); }
        }

        private void book_inv_update()
        {
            string id = dgvBookInv.SelectedRows[0].Cells[0].Value.ToString();
            string bookid = txtBIbookid.Text;
            string isbn = txtBInvISBN.Text;
            string rack = cmBIrack.Text;
            string Publish_Date = dtpBIpublishdate.Value.ToString("yyyy-MM-dd");
            int rbBIvalue = Book_Inv_radiobtn_value(); // buy,donate or government
            double price = 0;
            if (txtBIprice.Text == null || txtBIprice.Text == "") { price = 0; }
            else { price = Convert.ToDouble(txtBIprice.Text); }
            int quantity = 0;
            if (txtBIquantity.Text == null || txtBIquantity.Text == "") { quantity = 1; }
            else { quantity = Convert.ToInt32(txtBIquantity.Text); }
            string teacher = lblteacher.Text; 
            if (bookid != "" && isbn != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "update Book_Inventory set Book_ID = '" + bookid + "',isbn = '" + isbn + "',rack = '" + rack + "', " +
                        "Publish_Date = '" + Publish_Date + "',Take_Method = '" + rbBIvalue + "' ,price = '" + price + "'," +
                        "Quantity = '" + quantity + "', Teacher = '"+teacher+"'" +
                        " where id =  '" + id + "'";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Inventory Update success.");
                    grid_load_book_Inventory();
                    book_inventory_refreshbtn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid data Update. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Data Empty in ISBN , Name. operation fail !");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBIisbn_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void cmBIrack_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void cmBIrack_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmBIrack_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            DashboradTeacher td = new DashboradTeacher(lblteacher.Text);
            this.Hide();
            td.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBIrefresh_Click(object sender, EventArgs e)
        {
            grid_load_book_Inventory();
            book_inventory_refreshbtn();
        }

        private void book_inventory_refreshbtn()
        {
            txtBIbookid.Text = "";
            txtBInvISBN.Text = "";
            cmBIrack.Text = "";
            dtpBIpublishdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            rbBIbuy.Checked = false;
            rbBIdonate.Checked = false;
            rbBIgov.Checked = false; // set radio buttons
            txtBIprice.Text = "";
            txtBIquantity.Text = "";
            btnBIadd.Enabled = true;
            btnBIdelete.Enabled = false;
            btnBIupdate.Enabled = false;
        }

        private void btnBIchk_ISBN_Click(object sender, EventArgs e)
        {
            string isbn = txtBInvISBN.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select id,Book_ID,isbn,rack,Publish_Date,Take_Method,price,Quantity,teacher " +
                    " from book_inventory where isbn = '" + isbn + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvBookInv.DataSource = dta;
                con.Close();
                check_book_name();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private int check_isbn_book_inv() 
        
        {
            try
            {

                SqlConnection con = new SqlConnection(cn.connectionstring());
                con.Open();
                string sql = "select * from Book where isbn='" + txtBInvISBN.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    return 1;
                }
                else
                {
                    MessageBox.Show("invalid ISBN or Empty box. Please Check ISBN first.");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error !");
                return 0;
            }
        }
        private void check_book_name()
        {

            string isbn = txtBInvISBN.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select Name from Book   where isbn = '" + isbn + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    DataRow row = dta.Rows[0];
                    lblBIBname.Text = row[0].ToString();
                    lblbookn.Text = "Book Name : ";
                }
                else
                {
                    MessageBox.Show("Book Not Registered with ISBN. Please add book before Add to the inventory.");
                }
                con.Close();
                //refresh_book();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : ISBN empty");
            }
            

        }

        private void btnBIBISearch_Click(object sender, EventArgs e)
        {
            string Book_ID = txtBIBIsearch.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select * " +
                    " from Book_Inventory where Book_ID = '" + Book_ID + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvBookInv.DataSource = dta;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void Book_Inventory_Search_Like_Book_ID() //load book inventry data according to ISBN number
        {
            string Book_ID = txtBIBIsearch.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select * " +
                    " from Book_Inventory where Book_ID like '" + Book_ID + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvBookInv.DataSource = dta;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void Book_Inventory_Search_Like_ISBN() //load book inventry data according to ISBN number
        {
            string isbn = txtBIisbnsearch.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select * " +
                    " from Book_Inventory where ISBN like '" + isbn + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvBookInv.DataSource = dta;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void txtBIisbnsearch_KeyUp(object sender, KeyEventArgs e)
        {
            Book_Inventory_Search_Like_ISBN();
        }

        private void btnBIISBNsearch_Click(object sender, EventArgs e)
        {
            string isbn = txtBIisbnsearch.Text;
            try
            {
                SqlConnection con = new SqlConnection(cn.connectionstring());
                string sql = "select * " +
                    " from Book_Inventory where ISBN = '" + isbn + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvBookInv.DataSource = dta;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
            }
        }

        private void txtBIBIsearch_KeyUp(object sender, KeyEventArgs e)
        {
            Book_Inventory_Search_Like_Book_ID();
        }

        private void cmBIrack_Leave(object sender, EventArgs e)
        {
          
        }

        private void cmBIrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBIrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmBIrack.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBIrack.AutoCompleteSource = AutoCompleteSource.ListItems;
            
        }
        private void cmBIrack_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvBookInv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtBIbookid.Text = dgvBookInv.SelectedRows[0].Cells[1].Value.ToString();
                txtBInvISBN.Text = dgvBookInv.SelectedRows[0].Cells[2].Value.ToString();
                cmBIrack.Text = dgvBookInv.SelectedRows[0].Cells[3].Value.ToString();
                dtpBIpublishdate.Text = dgvBookInv.SelectedRows[0].Cells[4].Value.ToString();
                Book_Inv_radiobtn_value_update(Convert.ToInt32(dgvBookInv.SelectedRows[0].Cells[5].Value.ToString())); // set radio buttons
                txtBIprice.Text = dgvBookInv.SelectedRows[0].Cells[6].Value.ToString();
                txtBIquantity.Text = dgvBookInv.SelectedRows[0].Cells[7].Value.ToString();
                btnBIadd.Enabled = false;
                btnBIdelete.Enabled = true;
                btnBIupdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("selection error. Please double click row begining column. \n");
            }
        }

        private void Book_Inv_radiobtn_value_update( int a)
        {
            
            if (a==1)
            { rbBIbuy.Checked = true; }
            else if (a==2)
            {
                rbBIdonate.Checked = true; 
            }
            else if (a==3)
            { rbBIgov.Checked = true; }
        }

        private void btnBIdelete_Click(object sender, EventArgs e)
        {
            if (txtBIbookid.Text != "")
            {
                try
                {

                    SqlConnection con = new SqlConnection(cn.connectionstring());
                    con.Open();
                    string sql = "delete from Book_Inventory where Id = '" + dgvBookInv.SelectedRows[0].Cells[0].Value.ToString() + "' ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    btnBIadd.Enabled = true;
                    btnBIdelete.Enabled = false;
                    btnBIupdate.Enabled = false;
                    grid_load_book_Inventory();
                    book_inventory_refreshbtn();
                    MessageBox.Show("Deleted !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Delete. operation fail !");
                }
            }
            else
            {
                MessageBox.Show("Data Empty in ISBN. operation fail !");
            }
        }
    }
}
