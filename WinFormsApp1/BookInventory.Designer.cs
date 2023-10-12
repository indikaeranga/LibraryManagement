namespace WinFormsApp1
{
    partial class BookInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInventory));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBsearch = new System.Windows.Forms.Button();
            this.txtBsearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBisbn = new System.Windows.Forms.TextBox();
            this.txtBpublish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBdelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBupdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBadd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBprint = new System.Windows.Forms.TextBox();
            this.txtBpublisher = new System.Windows.Forms.Label();
            this.txtBpages = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp1stpublish = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBdescription = new System.Windows.Forms.RichTextBox();
            this.txtBname = new System.Windows.Forms.TextBox();
            this.txtBauthor = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvBookInv = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBIISBNsearch = new System.Windows.Forms.Button();
            this.btnBIBISearch = new System.Windows.Forms.Button();
            this.txtBIBIsearch = new System.Windows.Forms.TextBox();
            this.txtBIisbnsearch = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblbookn = new System.Windows.Forms.Label();
            this.btnBIchk_ISBN = new System.Windows.Forms.Button();
            this.txtBInvISBN = new System.Windows.Forms.TextBox();
            this.lblrackname = new System.Windows.Forms.Label();
            this.lblBIBname = new System.Windows.Forms.Label();
            this.btnBIrefresh = new System.Windows.Forms.Button();
            this.btnBIdelete = new System.Windows.Forms.Button();
            this.btnBIupdate = new System.Windows.Forms.Button();
            this.btnBIadd = new System.Windows.Forms.Button();
            this.txtBIquantity = new System.Windows.Forms.TextBox();
            this.txtBIprice = new System.Windows.Forms.TextBox();
            this.rbBIgov = new System.Windows.Forms.RadioButton();
            this.rbBIdonate = new System.Windows.Forms.RadioButton();
            this.rbBIbuy = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpBIpublishdate = new System.Windows.Forms.DateTimePicker();
            this.cmBIrack = new System.Windows.Forms.ComboBox();
            this.txtBIbookid = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblteacher = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInv)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1788, 850);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBook);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1780, 817);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book / ISBN Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(18, 274);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 29;
            this.dgvBook.Size = new System.Drawing.Size(1742, 537);
            this.dgvBook.TabIndex = 27;
            this.dgvBook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBook_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBsearch);
            this.groupBox2.Controls.Add(this.txtBsearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(1367, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 231);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnBsearch
            // 
            this.btnBsearch.Location = new System.Drawing.Point(89, 83);
            this.btnBsearch.Name = "btnBsearch";
            this.btnBsearch.Size = new System.Drawing.Size(94, 29);
            this.btnBsearch.TabIndex = 2;
            this.btnBsearch.Text = "Search";
            this.btnBsearch.UseVisualStyleBackColor = true;
            this.btnBsearch.Click += new System.EventHandler(this.btnBsearch_Click);
            // 
            // txtBsearch
            // 
            this.txtBsearch.Location = new System.Drawing.Point(89, 42);
            this.txtBsearch.Name = "txtBsearch";
            this.txtBsearch.Size = new System.Drawing.Size(271, 27);
            this.txtBsearch.TabIndex = 1;
            this.txtBsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBsearch_KeyPress);
            this.txtBsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBsearch_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "ISBN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBisbn);
            this.groupBox1.Controls.Add(this.txtBpublish);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrefresh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBdelete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBupdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBadd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBprint);
            this.groupBox1.Controls.Add(this.txtBpublisher);
            this.groupBox1.Controls.Add(this.txtBpages);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtp1stpublish);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBdescription);
            this.groupBox1.Controls.Add(this.txtBname);
            this.groupBox1.Controls.Add(this.txtBauthor);
            this.groupBox1.Location = new System.Drawing.Point(18, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1320, 231);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage";
            // 
            // txtBisbn
            // 
            this.txtBisbn.Location = new System.Drawing.Point(118, 38);
            this.txtBisbn.Name = "txtBisbn";
            this.txtBisbn.Size = new System.Drawing.Size(308, 27);
            this.txtBisbn.TabIndex = 10;
            // 
            // txtBpublish
            // 
            this.txtBpublish.Location = new System.Drawing.Point(975, 38);
            this.txtBpublish.Name = "txtBpublish";
            this.txtBpublish.Size = new System.Drawing.Size(330, 27);
            this.txtBpublish.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN *";
            // 
            // btnBrefresh
            // 
            this.btnBrefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrefresh.ForeColor = System.Drawing.Color.Green;
            this.btnBrefresh.Location = new System.Drawing.Point(466, 173);
            this.btnBrefresh.Name = "btnBrefresh";
            this.btnBrefresh.Size = new System.Drawing.Size(94, 29);
            this.btnBrefresh.TabIndex = 23;
            this.btnBrefresh.Text = "Refresh";
            this.btnBrefresh.UseVisualStyleBackColor = true;
            this.btnBrefresh.Click += new System.EventHandler(this.btnBrefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name *";
            // 
            // btnBdelete
            // 
            this.btnBdelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBdelete.ForeColor = System.Drawing.Color.Red;
            this.btnBdelete.Location = new System.Drawing.Point(349, 173);
            this.btnBdelete.Name = "btnBdelete";
            this.btnBdelete.Size = new System.Drawing.Size(94, 29);
            this.btnBdelete.TabIndex = 22;
            this.btnBdelete.Text = "Delete";
            this.btnBdelete.UseVisualStyleBackColor = true;
            this.btnBdelete.Click += new System.EventHandler(this.btnBdelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // btnBupdate
            // 
            this.btnBupdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBupdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBupdate.Location = new System.Drawing.Point(233, 173);
            this.btnBupdate.Name = "btnBupdate";
            this.btnBupdate.Size = new System.Drawing.Size(94, 29);
            this.btnBupdate.TabIndex = 21;
            this.btnBupdate.Text = "Update";
            this.btnBupdate.UseVisualStyleBackColor = true;
            this.btnBupdate.Click += new System.EventHandler(this.btnBupdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // btnBadd
            // 
            this.btnBadd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBadd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBadd.Location = new System.Drawing.Point(118, 173);
            this.btnBadd.Name = "btnBadd";
            this.btnBadd.Size = new System.Drawing.Size(94, 29);
            this.btnBadd.TabIndex = 20;
            this.btnBadd.Text = "Add Book";
            this.btnBadd.UseVisualStyleBackColor = true;
            this.btnBadd.Click += new System.EventHandler(this.btnBadd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "1 st Publish";
            // 
            // txtBprint
            // 
            this.txtBprint.Location = new System.Drawing.Point(975, 119);
            this.txtBprint.Name = "txtBprint";
            this.txtBprint.Size = new System.Drawing.Size(330, 27);
            this.txtBprint.TabIndex = 19;
            // 
            // txtBpublisher
            // 
            this.txtBpublisher.AutoSize = true;
            this.txtBpublisher.Location = new System.Drawing.Point(877, 41);
            this.txtBpublisher.Name = "txtBpublisher";
            this.txtBpublisher.Size = new System.Drawing.Size(69, 20);
            this.txtBpublisher.TabIndex = 7;
            this.txtBpublisher.Text = "Publisher";
            this.txtBpublisher.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtBpages
            // 
            this.txtBpages.Location = new System.Drawing.Point(975, 76);
            this.txtBpages.Name = "txtBpages";
            this.txtBpages.Size = new System.Drawing.Size(105, 27);
            this.txtBpages.TabIndex = 18;
            this.txtBpages.TextChanged += new System.EventHandler(this.txtpages_TextChanged);
            this.txtBpages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBpages_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(877, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Pages *";
            // 
            // dtp1stpublish
            // 
            this.dtp1stpublish.Location = new System.Drawing.Point(555, 115);
            this.dtp1stpublish.Name = "dtp1stpublish";
            this.dtp1stpublish.Size = new System.Drawing.Size(294, 27);
            this.dtp1stpublish.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(877, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Printing";
            // 
            // txtBdescription
            // 
            this.txtBdescription.Location = new System.Drawing.Point(555, 38);
            this.txtBdescription.Name = "txtBdescription";
            this.txtBdescription.Size = new System.Drawing.Size(294, 65);
            this.txtBdescription.TabIndex = 13;
            this.txtBdescription.Text = "";
            // 
            // txtBname
            // 
            this.txtBname.Location = new System.Drawing.Point(118, 76);
            this.txtBname.Name = "txtBname";
            this.txtBname.Size = new System.Drawing.Size(308, 27);
            this.txtBname.TabIndex = 11;
            // 
            // txtBauthor
            // 
            this.txtBauthor.Location = new System.Drawing.Point(118, 114);
            this.txtBauthor.Name = "txtBauthor";
            this.txtBauthor.Size = new System.Drawing.Size(308, 27);
            this.txtBauthor.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvBookInv);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1780, 817);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Book Inventory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvBookInv
            // 
            this.dgvBookInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInv.Location = new System.Drawing.Point(19, 306);
            this.dgvBookInv.Name = "dgvBookInv";
            this.dgvBookInv.RowHeadersWidth = 51;
            this.dgvBookInv.RowTemplate.Height = 29;
            this.dgvBookInv.Size = new System.Drawing.Size(1742, 537);
            this.dgvBookInv.TabIndex = 3;
            this.dgvBookInv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBookInv_MouseDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnBIISBNsearch);
            this.groupBox6.Controls.Add(this.btnBIBISearch);
            this.groupBox6.Controls.Add(this.txtBIBIsearch);
            this.groupBox6.Controls.Add(this.txtBIisbnsearch);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Location = new System.Drawing.Point(1220, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(541, 259);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search books in Inventory";
            // 
            // btnBIISBNsearch
            // 
            this.btnBIISBNsearch.Location = new System.Drawing.Point(407, 46);
            this.btnBIISBNsearch.Name = "btnBIISBNsearch";
            this.btnBIISBNsearch.Size = new System.Drawing.Size(94, 29);
            this.btnBIISBNsearch.TabIndex = 5;
            this.btnBIISBNsearch.Text = "Search";
            this.btnBIISBNsearch.UseVisualStyleBackColor = true;
            this.btnBIISBNsearch.Click += new System.EventHandler(this.btnBIISBNsearch_Click);
            // 
            // btnBIBISearch
            // 
            this.btnBIBISearch.Location = new System.Drawing.Point(407, 98);
            this.btnBIBISearch.Name = "btnBIBISearch";
            this.btnBIBISearch.Size = new System.Drawing.Size(94, 29);
            this.btnBIBISearch.TabIndex = 4;
            this.btnBIBISearch.Text = "Search";
            this.btnBIBISearch.UseVisualStyleBackColor = true;
            this.btnBIBISearch.Click += new System.EventHandler(this.btnBIBISearch_Click);
            // 
            // txtBIBIsearch
            // 
            this.txtBIBIsearch.Location = new System.Drawing.Point(135, 99);
            this.txtBIBIsearch.Name = "txtBIBIsearch";
            this.txtBIBIsearch.Size = new System.Drawing.Size(234, 27);
            this.txtBIBIsearch.TabIndex = 3;
            this.txtBIBIsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBIBIsearch_KeyUp);
            // 
            // txtBIisbnsearch
            // 
            this.txtBIisbnsearch.Location = new System.Drawing.Point(135, 49);
            this.txtBIisbnsearch.Name = "txtBIisbnsearch";
            this.txtBIisbnsearch.Size = new System.Drawing.Size(234, 27);
            this.txtBIisbnsearch.TabIndex = 2;
            this.txtBIisbnsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBIisbnsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBIisbnsearch_KeyUp);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(35, 58);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "ISBN";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(35, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "Book ID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblbookn);
            this.groupBox5.Controls.Add(this.btnBIchk_ISBN);
            this.groupBox5.Controls.Add(this.txtBInvISBN);
            this.groupBox5.Controls.Add(this.lblrackname);
            this.groupBox5.Controls.Add(this.lblBIBname);
            this.groupBox5.Controls.Add(this.btnBIrefresh);
            this.groupBox5.Controls.Add(this.btnBIdelete);
            this.groupBox5.Controls.Add(this.btnBIupdate);
            this.groupBox5.Controls.Add(this.btnBIadd);
            this.groupBox5.Controls.Add(this.txtBIquantity);
            this.groupBox5.Controls.Add(this.txtBIprice);
            this.groupBox5.Controls.Add(this.rbBIgov);
            this.groupBox5.Controls.Add(this.rbBIdonate);
            this.groupBox5.Controls.Add(this.rbBIbuy);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.dtpBIpublishdate);
            this.groupBox5.Controls.Add(this.cmBIrack);
            this.groupBox5.Controls.Add(this.txtBIbookid);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(19, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1181, 259);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inventory Management";
            // 
            // lblbookn
            // 
            this.lblbookn.AutoSize = true;
            this.lblbookn.Location = new System.Drawing.Point(20, 142);
            this.lblbookn.Name = "lblbookn";
            this.lblbookn.Size = new System.Drawing.Size(0, 20);
            this.lblbookn.TabIndex = 25;
            // 
            // btnBIchk_ISBN
            // 
            this.btnBIchk_ISBN.Location = new System.Drawing.Point(430, 102);
            this.btnBIchk_ISBN.Name = "btnBIchk_ISBN";
            this.btnBIchk_ISBN.Size = new System.Drawing.Size(138, 29);
            this.btnBIchk_ISBN.TabIndex = 24;
            this.btnBIchk_ISBN.Text = "Check Book Name";
            this.btnBIchk_ISBN.UseVisualStyleBackColor = true;
            this.btnBIchk_ISBN.Click += new System.EventHandler(this.btnBIchk_ISBN_Click);
            // 
            // txtBInvISBN
            // 
            this.txtBInvISBN.Location = new System.Drawing.Point(139, 103);
            this.txtBInvISBN.Name = "txtBInvISBN";
            this.txtBInvISBN.Size = new System.Drawing.Size(259, 27);
            this.txtBInvISBN.TabIndex = 23;
            // 
            // lblrackname
            // 
            this.lblrackname.AutoSize = true;
            this.lblrackname.Location = new System.Drawing.Point(139, 225);
            this.lblrackname.Name = "lblrackname";
            this.lblrackname.Size = new System.Drawing.Size(84, 20);
            this.lblrackname.TabIndex = 22;
            this.lblrackname.Text = "Rack Name";
            // 
            // lblBIBname
            // 
            this.lblBIBname.AutoSize = true;
            this.lblBIBname.Location = new System.Drawing.Point(139, 142);
            this.lblBIBname.Name = "lblBIBname";
            this.lblBIBname.Size = new System.Drawing.Size(0, 20);
            this.lblBIBname.TabIndex = 21;
            // 
            // btnBIrefresh
            // 
            this.btnBIrefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBIrefresh.ForeColor = System.Drawing.Color.Green;
            this.btnBIrefresh.Location = new System.Drawing.Point(1055, 192);
            this.btnBIrefresh.Name = "btnBIrefresh";
            this.btnBIrefresh.Size = new System.Drawing.Size(94, 29);
            this.btnBIrefresh.TabIndex = 20;
            this.btnBIrefresh.Text = "Refresh";
            this.btnBIrefresh.UseVisualStyleBackColor = true;
            this.btnBIrefresh.Click += new System.EventHandler(this.btnBIrefresh_Click);
            // 
            // btnBIdelete
            // 
            this.btnBIdelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBIdelete.ForeColor = System.Drawing.Color.Red;
            this.btnBIdelete.Location = new System.Drawing.Point(1055, 142);
            this.btnBIdelete.Name = "btnBIdelete";
            this.btnBIdelete.Size = new System.Drawing.Size(94, 29);
            this.btnBIdelete.TabIndex = 19;
            this.btnBIdelete.Text = "Delete";
            this.btnBIdelete.UseVisualStyleBackColor = true;
            this.btnBIdelete.Click += new System.EventHandler(this.btnBIdelete_Click);
            // 
            // btnBIupdate
            // 
            this.btnBIupdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBIupdate.Location = new System.Drawing.Point(1055, 94);
            this.btnBIupdate.Name = "btnBIupdate";
            this.btnBIupdate.Size = new System.Drawing.Size(94, 29);
            this.btnBIupdate.TabIndex = 18;
            this.btnBIupdate.Text = "Update";
            this.btnBIupdate.UseVisualStyleBackColor = true;
            this.btnBIupdate.Click += new System.EventHandler(this.btnBIupdate_Click);
            // 
            // btnBIadd
            // 
            this.btnBIadd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBIadd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBIadd.Location = new System.Drawing.Point(1055, 46);
            this.btnBIadd.Name = "btnBIadd";
            this.btnBIadd.Size = new System.Drawing.Size(94, 29);
            this.btnBIadd.TabIndex = 17;
            this.btnBIadd.Text = "Add New";
            this.btnBIadd.UseVisualStyleBackColor = true;
            this.btnBIadd.Click += new System.EventHandler(this.btnBIadd_Click);
            // 
            // txtBIquantity
            // 
            this.txtBIquantity.Enabled = false;
            this.txtBIquantity.Location = new System.Drawing.Point(767, 192);
            this.txtBIquantity.Name = "txtBIquantity";
            this.txtBIquantity.Size = new System.Drawing.Size(125, 27);
            this.txtBIquantity.TabIndex = 16;
            this.txtBIquantity.Text = "1";
            // 
            // txtBIprice
            // 
            this.txtBIprice.Location = new System.Drawing.Point(767, 143);
            this.txtBIprice.Name = "txtBIprice";
            this.txtBIprice.Size = new System.Drawing.Size(125, 27);
            this.txtBIprice.TabIndex = 15;
            // 
            // rbBIgov
            // 
            this.rbBIgov.AutoSize = true;
            this.rbBIgov.Location = new System.Drawing.Point(913, 99);
            this.rbBIgov.Name = "rbBIgov";
            this.rbBIgov.Size = new System.Drawing.Size(111, 24);
            this.rbBIgov.TabIndex = 14;
            this.rbBIgov.TabStop = true;
            this.rbBIgov.Text = "Government";
            this.rbBIgov.UseVisualStyleBackColor = true;
            // 
            // rbBIdonate
            // 
            this.rbBIdonate.AutoSize = true;
            this.rbBIdonate.Location = new System.Drawing.Point(828, 99);
            this.rbBIdonate.Name = "rbBIdonate";
            this.rbBIdonate.Size = new System.Drawing.Size(79, 24);
            this.rbBIdonate.TabIndex = 13;
            this.rbBIdonate.TabStop = true;
            this.rbBIdonate.Text = "Donate";
            this.rbBIdonate.UseVisualStyleBackColor = true;
            // 
            // rbBIbuy
            // 
            this.rbBIbuy.AutoSize = true;
            this.rbBIbuy.Location = new System.Drawing.Point(767, 99);
            this.rbBIbuy.Name = "rbBIbuy";
            this.rbBIbuy.Size = new System.Drawing.Size(54, 24);
            this.rbBIbuy.TabIndex = 12;
            this.rbBIbuy.TabStop = true;
            this.rbBIbuy.Text = "Buy";
            this.rbBIbuy.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(620, 199);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 20);
            this.label23.TabIndex = 10;
            this.label23.Text = "Quantity";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(620, 150);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 20);
            this.label22.TabIndex = 9;
            this.label22.Text = "Price";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(620, 103);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 20);
            this.label21.TabIndex = 8;
            this.label21.Text = "Take_Method";
            // 
            // dtpBIpublishdate
            // 
            this.dtpBIpublishdate.Location = new System.Drawing.Point(767, 43);
            this.dtpBIpublishdate.Name = "dtpBIpublishdate";
            this.dtpBIpublishdate.Size = new System.Drawing.Size(259, 27);
            this.dtpBIpublishdate.TabIndex = 7;
            // 
            // cmBIrack
            // 
            this.cmBIrack.FormattingEnabled = true;
            this.cmBIrack.Location = new System.Drawing.Point(139, 181);
            this.cmBIrack.Name = "cmBIrack";
            this.cmBIrack.Size = new System.Drawing.Size(259, 28);
            this.cmBIrack.TabIndex = 6;
            this.cmBIrack.SelectedIndexChanged += new System.EventHandler(this.cmBIrack_SelectedIndexChanged);
            this.cmBIrack.SelectionChangeCommitted += new System.EventHandler(this.cmBIrack_SelectionChangeCommitted);
            this.cmBIrack.SelectedValueChanged += new System.EventHandler(this.cmBIrack_SelectedValueChanged);
            this.cmBIrack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmBIrack_KeyDown);
            this.cmBIrack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmBIrack_KeyPress);
            this.cmBIrack.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmBIrack_KeyUp);
            this.cmBIrack.Leave += new System.EventHandler(this.cmBIrack_Leave);
            // 
            // txtBIbookid
            // 
            this.txtBIbookid.Location = new System.Drawing.Point(139, 51);
            this.txtBIbookid.Name = "txtBIbookid";
            this.txtBIbookid.Size = new System.Drawing.Size(259, 27);
            this.txtBIbookid.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(620, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 20);
            this.label20.TabIndex = 3;
            this.label20.Text = "Publish Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 189);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Rack";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "ISBN *";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Book ID *";
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Location = new System.Drawing.Point(105, 9);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(60, 20);
            this.lblteacher.TabIndex = 25;
            this.lblteacher.Text = "Teacher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(1590, 26);
            this.label6.MinimumSize = new System.Drawing.Size(32, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 32);
            this.label6.TabIndex = 1;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Welcome";
            // 
            // BookInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Name = "BookInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Inventory";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInv)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label txtBpublisher;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private DateTimePicker dtp1stpublish;
        private RichTextBox txtBdescription;
        private TextBox txtBauthor;
        private TextBox txtBname;
        private TextBox txtBisbn;
        private Button btnBrefresh;
        private Button btnBdelete;
        private Button btnBupdate;
        private Button btnBadd;
        private TextBox txtBprint;
        private TextBox txtBpages;
        private TextBox txtBpublish;
        private GroupBox groupBox1;
        private DataGridView dgvBook;
        private GroupBox groupBox2;
        private Button btnBsearch;
        private TextBox txtBsearch;
        private Label label5;
        private Label lblteacher;
        private TabPage tabPage3;
        private GroupBox groupBox5;
        private DateTimePicker dtpBIpublishdate;
        private ComboBox cmBIrack;
        private TextBox txtBIbookid;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private TextBox txtBIquantity;
        private TextBox txtBIprice;
        private RadioButton rbBIgov;
        private RadioButton rbBIdonate;
        private RadioButton rbBIbuy;
        private Label label23;
        private Label label22;
        private Label label21;
        private Button btnBIrefresh;
        private Button btnBIdelete;
        private Button btnBIupdate;
        private Button btnBIadd;
        private GroupBox groupBox6;
        private Button btnBIBISearch;
        private TextBox txtBIBIsearch;
        private TextBox txtBIisbnsearch;
        private Label label26;
        private Label label25;
        private Button btnBIISBNsearch;
        private DataGridView dgvBookInv;
        private Label lblrackname;
        private Label lblBIBname;
        private Label label6;
        private Label label8;
        private TextBox txtBInvISBN;
        private Button btnBIchk_ISBN;
        private Label lblbookn;
    }
}