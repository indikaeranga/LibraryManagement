namespace WinFormsApp1
{
    partial class AdminDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbteacher = new System.Windows.Forms.RadioButton();
            this.rbadmin = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvbookcat = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Name_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btnbcrefresh = new System.Windows.Forms.Button();
            this.btnbcDel = new System.Windows.Forms.Button();
            this.btnbcUpdate = new System.Windows.Forms.Button();
            this.btnbcadd = new System.Windows.Forms.Button();
            this.txtcatremark = new System.Windows.Forms.TextBox();
            this.txtcatname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvrack = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rack_Name_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrefreshR = new System.Windows.Forms.Button();
            this.btnDeleteR = new System.Windows.Forms.Button();
            this.btnupdateR = new System.Windows.Forms.Button();
            this.btnaddR = new System.Windows.Forms.Button();
            this.txtrname = new System.Windows.Forms.TextBox();
            this.txtrid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookcat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrack)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1788, 879);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbteacher);
            this.tabPage1.Controls.Add(this.rbadmin);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtaddress);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnrefresh);
            this.tabPage1.Controls.Add(this.dgvTeacher);
            this.tabPage1.Controls.Add(this.btndelete);
            this.tabPage1.Controls.Add(this.btnupdate);
            this.tabPage1.Controls.Add(this.btnadd);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtphone);
            this.tabPage1.Controls.Add(this.txtpass);
            this.tabPage1.Controls.Add(this.txtname);
            this.tabPage1.Controls.Add(this.txtnic);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1780, 846);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Teacher";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // rbteacher
            // 
            this.rbteacher.AutoSize = true;
            this.rbteacher.Checked = true;
            this.rbteacher.Location = new System.Drawing.Point(261, 392);
            this.rbteacher.Name = "rbteacher";
            this.rbteacher.Size = new System.Drawing.Size(81, 24);
            this.rbteacher.TabIndex = 20;
            this.rbteacher.TabStop = true;
            this.rbteacher.Text = "Teacher";
            this.rbteacher.UseVisualStyleBackColor = true;
            // 
            // rbadmin
            // 
            this.rbadmin.AutoSize = true;
            this.rbadmin.Location = new System.Drawing.Point(164, 394);
            this.rbadmin.Name = "rbadmin";
            this.rbadmin.Size = new System.Drawing.Size(74, 24);
            this.rbadmin.TabIndex = 19;
            this.rbadmin.Text = "Admin";
            this.rbadmin.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Access";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(164, 310);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(275, 66);
            this.txtaddress.TabIndex = 17;
            this.txtaddress.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 585);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "(2) Double click table row for update and delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "(1) * Required field";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(345, 467);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(94, 29);
            this.btnrefresh.TabIndex = 12;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(477, 57);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowHeadersWidth = 51;
            this.dgvTeacher.RowTemplate.Height = 29;
            this.dgvTeacher.Size = new System.Drawing.Size(1297, 783);
            this.dgvTeacher.TabIndex = 11;
            this.dgvTeacher.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTeacher_MouseDoubleClick);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(237, 467);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 29);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(128, 467);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 29);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(20, 467);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 29);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add New";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "NIC *";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(164, 249);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(275, 27);
            this.txtphone.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(164, 184);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(275, 27);
            this.txtpass.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(164, 122);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(275, 27);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(164, 57);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(275, 27);
            this.txtnic.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1780, 807);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Rack & Book Categories";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvbookcat);
            this.groupBox2.Controls.Add(this.Btnbcrefresh);
            this.groupBox2.Controls.Add(this.btnbcDel);
            this.groupBox2.Controls.Add(this.btnbcUpdate);
            this.groupBox2.Controls.Add(this.btnbcadd);
            this.groupBox2.Controls.Add(this.txtcatremark);
            this.groupBox2.Controls.Add(this.txtcatname);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(841, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 802);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Category";
            // 
            // dgvbookcat
            // 
            this.dgvbookcat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbookcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbookcat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Category_Name_ID,
            this.Remark});
            this.dgvbookcat.Location = new System.Drawing.Point(22, 262);
            this.dgvbookcat.Name = "dgvbookcat";
            this.dgvbookcat.RowHeadersWidth = 51;
            this.dgvbookcat.RowTemplate.Height = 29;
            this.dgvbookcat.Size = new System.Drawing.Size(816, 534);
            this.dgvbookcat.TabIndex = 10;
            this.dgvbookcat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvbookcat_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Category_Name_ID
            // 
            this.Category_Name_ID.DataPropertyName = "Category_Name_ID";
            this.Category_Name_ID.HeaderText = "Category";
            this.Category_Name_ID.MinimumWidth = 6;
            this.Category_Name_ID.Name = "Category_Name_ID";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "Remark";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            // 
            // Btnbcrefresh
            // 
            this.Btnbcrefresh.Location = new System.Drawing.Point(652, 203);
            this.Btnbcrefresh.Name = "Btnbcrefresh";
            this.Btnbcrefresh.Size = new System.Drawing.Size(94, 29);
            this.Btnbcrefresh.TabIndex = 9;
            this.Btnbcrefresh.Text = "Refresh";
            this.Btnbcrefresh.UseVisualStyleBackColor = true;
            this.Btnbcrefresh.Click += new System.EventHandler(this.Btnbcrefresh_Click);
            // 
            // btnbcDel
            // 
            this.btnbcDel.Location = new System.Drawing.Point(529, 203);
            this.btnbcDel.Name = "btnbcDel";
            this.btnbcDel.Size = new System.Drawing.Size(94, 29);
            this.btnbcDel.TabIndex = 8;
            this.btnbcDel.Text = "Delete";
            this.btnbcDel.UseVisualStyleBackColor = true;
            this.btnbcDel.Click += new System.EventHandler(this.btnbcDel_Click);
            // 
            // btnbcUpdate
            // 
            this.btnbcUpdate.Location = new System.Drawing.Point(411, 203);
            this.btnbcUpdate.Name = "btnbcUpdate";
            this.btnbcUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnbcUpdate.TabIndex = 7;
            this.btnbcUpdate.Text = "Update";
            this.btnbcUpdate.UseVisualStyleBackColor = true;
            this.btnbcUpdate.Click += new System.EventHandler(this.btnbcUpdate_Click);
            // 
            // btnbcadd
            // 
            this.btnbcadd.Location = new System.Drawing.Point(291, 203);
            this.btnbcadd.Name = "btnbcadd";
            this.btnbcadd.Size = new System.Drawing.Size(94, 29);
            this.btnbcadd.TabIndex = 6;
            this.btnbcadd.Text = "Add New";
            this.btnbcadd.UseVisualStyleBackColor = true;
            this.btnbcadd.Click += new System.EventHandler(this.btnbcadd_Click);
            // 
            // txtcatremark
            // 
            this.txtcatremark.Location = new System.Drawing.Point(291, 127);
            this.txtcatremark.Name = "txtcatremark";
            this.txtcatremark.Size = new System.Drawing.Size(332, 27);
            this.txtcatremark.TabIndex = 5;
            // 
            // txtcatname
            // 
            this.txtcatname.Location = new System.Drawing.Point(291, 69);
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.Size = new System.Drawing.Size(332, 27);
            this.txtcatname.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Remark";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name / ID *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvrack);
            this.groupBox1.Controls.Add(this.btnrefreshR);
            this.groupBox1.Controls.Add(this.btnDeleteR);
            this.groupBox1.Controls.Add(this.btnupdateR);
            this.groupBox1.Controls.Add(this.btnaddR);
            this.groupBox1.Controls.Add(this.txtrname);
            this.groupBox1.Controls.Add(this.txtrid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(86, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 802);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rack";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvrack
            // 
            this.dgvrack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Rack_Name_ID,
            this.dataGridViewTextBoxColumn2});
            this.dgvrack.Location = new System.Drawing.Point(16, 262);
            this.dgvrack.Name = "dgvrack";
            this.dgvrack.RowHeadersWidth = 51;
            this.dgvrack.RowTemplate.Height = 29;
            this.dgvrack.Size = new System.Drawing.Size(620, 534);
            this.dgvrack.TabIndex = 8;
            this.dgvrack.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvrack_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Rack_Name_ID
            // 
            this.Rack_Name_ID.DataPropertyName = "Rack_Name_ID";
            this.Rack_Name_ID.HeaderText = "Rack Name / ID";
            this.Rack_Name_ID.MinimumWidth = 6;
            this.Rack_Name_ID.Name = "Rack_Name_ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn2.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnrefreshR
            // 
            this.btnrefreshR.Location = new System.Drawing.Point(548, 203);
            this.btnrefreshR.Name = "btnrefreshR";
            this.btnrefreshR.Size = new System.Drawing.Size(94, 29);
            this.btnrefreshR.TabIndex = 7;
            this.btnrefreshR.Text = "Refresh";
            this.btnrefreshR.UseVisualStyleBackColor = true;
            this.btnrefreshR.Click += new System.EventHandler(this.btnrefreshR_Click);
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.Location = new System.Drawing.Point(436, 203);
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteR.TabIndex = 6;
            this.btnDeleteR.Text = "Delete";
            this.btnDeleteR.UseVisualStyleBackColor = true;
            this.btnDeleteR.Click += new System.EventHandler(this.btnDeleteR_Click);
            // 
            // btnupdateR
            // 
            this.btnupdateR.Location = new System.Drawing.Point(322, 203);
            this.btnupdateR.Name = "btnupdateR";
            this.btnupdateR.Size = new System.Drawing.Size(94, 29);
            this.btnupdateR.TabIndex = 5;
            this.btnupdateR.Text = "Update";
            this.btnupdateR.UseVisualStyleBackColor = true;
            this.btnupdateR.Click += new System.EventHandler(this.btnupdateR_Click);
            // 
            // btnaddR
            // 
            this.btnaddR.Location = new System.Drawing.Point(209, 203);
            this.btnaddR.Name = "btnaddR";
            this.btnaddR.Size = new System.Drawing.Size(94, 29);
            this.btnaddR.TabIndex = 4;
            this.btnaddR.Text = "Add New";
            this.btnaddR.UseVisualStyleBackColor = true;
            this.btnaddR.Click += new System.EventHandler(this.btnaddR_Click);
            // 
            // txtrname
            // 
            this.txtrname.Location = new System.Drawing.Point(209, 127);
            this.txtrname.Name = "txtrname";
            this.txtrname.Size = new System.Drawing.Size(321, 27);
            this.txtrname.TabIndex = 3;
            // 
            // txtrid
            // 
            this.txtrid.Location = new System.Drawing.Point(209, 69);
            this.txtrid.Name = "txtrid";
            this.txtrid.Size = new System.Drawing.Size(321, 27);
            this.txtrid.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Remark";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rack Name / ID *";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookcat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtphone;
        private TextBox txtpass;
        private TextBox txtname;
        private TextBox txtnic;
        private DataGridView dgvTeacher;
        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private Button btnrefresh;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private DataGridView dgvrack;
        private Button btnrefreshR;
        private Button btnDeleteR;
        private Button btnupdateR;
        private Button btnaddR;
        private TextBox txtrname;
        private TextBox txtrid;
        private DataGridView dgvbookcat;
        private Button Btnbcrefresh;
        private Button btnbcDel;
        private Button btnbcUpdate;
        private Button btnbcadd;
        private TextBox txtcatremark;
        private TextBox txtcatname;
        private Label label11;
        private Label label10;
        private Label label12;
        private RadioButton rbteacher;
        private RadioButton rbadmin;
        private Label label13;
        private RichTextBox txtaddress;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Category_Name_ID;
        private DataGridViewTextBoxColumn Remark;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Rack_Name_ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}