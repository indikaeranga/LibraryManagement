namespace WinFormsApp1
{
    partial class StudentManage
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSdelete = new System.Windows.Forms.Button();
            this.btnSrefresh = new System.Windows.Forms.Button();
            this.btnSupdate = new System.Windows.Forms.Button();
            this.btnSadd = new System.Windows.Forms.Button();
            this.txtsaddress = new System.Windows.Forms.RichTextBox();
            this.txtsphone = new System.Windows.Forms.TextBox();
            this.txtsgrade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpsbirth = new System.Windows.Forms.DateTimePicker();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSidsearch = new System.Windows.Forms.Button();
            this.txtsid_search = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvstudentlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblteacher = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSdelete);
            this.groupBox3.Controls.Add(this.btnSrefresh);
            this.groupBox3.Controls.Add(this.btnSupdate);
            this.groupBox3.Controls.Add(this.btnSadd);
            this.groupBox3.Controls.Add(this.txtsaddress);
            this.groupBox3.Controls.Add(this.txtsphone);
            this.groupBox3.Controls.Add(this.txtsgrade);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dtpsbirth);
            this.groupBox3.Controls.Add(this.txtsname);
            this.groupBox3.Controls.Add(this.txtsid);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(25, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1218, 252);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manage";
            // 
            // btnSdelete
            // 
            this.btnSdelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSdelete.ForeColor = System.Drawing.Color.Red;
            this.btnSdelete.Location = new System.Drawing.Point(1056, 150);
            this.btnSdelete.Name = "btnSdelete";
            this.btnSdelete.Size = new System.Drawing.Size(94, 29);
            this.btnSdelete.TabIndex = 16;
            this.btnSdelete.Text = "Delete";
            this.btnSdelete.UseVisualStyleBackColor = true;
            this.btnSdelete.Click += new System.EventHandler(this.btnSdelete_Click);
            // 
            // btnSrefresh
            // 
            this.btnSrefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSrefresh.ForeColor = System.Drawing.Color.Green;
            this.btnSrefresh.Location = new System.Drawing.Point(1056, 198);
            this.btnSrefresh.Name = "btnSrefresh";
            this.btnSrefresh.Size = new System.Drawing.Size(94, 29);
            this.btnSrefresh.TabIndex = 15;
            this.btnSrefresh.Text = "Refresh";
            this.btnSrefresh.UseVisualStyleBackColor = true;
            this.btnSrefresh.Click += new System.EventHandler(this.btnSrefresh_Click);
            // 
            // btnSupdate
            // 
            this.btnSupdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupdate.Location = new System.Drawing.Point(1056, 101);
            this.btnSupdate.Name = "btnSupdate";
            this.btnSupdate.Size = new System.Drawing.Size(94, 29);
            this.btnSupdate.TabIndex = 13;
            this.btnSupdate.Text = "Update";
            this.btnSupdate.UseVisualStyleBackColor = true;
            this.btnSupdate.Click += new System.EventHandler(this.btnSupdate_Click);
            // 
            // btnSadd
            // 
            this.btnSadd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSadd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSadd.Location = new System.Drawing.Point(1056, 52);
            this.btnSadd.Name = "btnSadd";
            this.btnSadd.Size = new System.Drawing.Size(94, 29);
            this.btnSadd.TabIndex = 12;
            this.btnSadd.Text = "Add New";
            this.btnSadd.UseVisualStyleBackColor = true;
            this.btnSadd.Click += new System.EventHandler(this.btnSadd_Click);
            // 
            // txtsaddress
            // 
            this.txtsaddress.Location = new System.Drawing.Point(643, 147);
            this.txtsaddress.Name = "txtsaddress";
            this.txtsaddress.Size = new System.Drawing.Size(323, 80);
            this.txtsaddress.TabIndex = 11;
            this.txtsaddress.Text = "";
            // 
            // txtsphone
            // 
            this.txtsphone.Location = new System.Drawing.Point(643, 102);
            this.txtsphone.Name = "txtsphone";
            this.txtsphone.Size = new System.Drawing.Size(323, 27);
            this.txtsphone.TabIndex = 10;
            // 
            // txtsgrade
            // 
            this.txtsgrade.Location = new System.Drawing.Point(643, 53);
            this.txtsgrade.Name = "txtsgrade";
            this.txtsgrade.Size = new System.Drawing.Size(323, 27);
            this.txtsgrade.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(555, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(555, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(555, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Grade";
            // 
            // dtpsbirth
            // 
            this.dtpsbirth.Location = new System.Drawing.Point(181, 145);
            this.dtpsbirth.Name = "dtpsbirth";
            this.dtpsbirth.Size = new System.Drawing.Size(323, 27);
            this.dtpsbirth.TabIndex = 5;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(181, 98);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(323, 27);
            this.txtsname.TabIndex = 4;
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(181, 53);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(323, 27);
            this.txtsid.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "BirthDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Student ID *";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnSidsearch);
            this.groupBox4.Controls.Add(this.txtsid_search);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(1284, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(494, 252);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(307, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Double click table row for update and delete";
            // 
            // btnSidsearch
            // 
            this.btnSidsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSidsearch.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnSidsearch.Location = new System.Drawing.Point(166, 105);
            this.btnSidsearch.Name = "btnSidsearch";
            this.btnSidsearch.Size = new System.Drawing.Size(94, 29);
            this.btnSidsearch.TabIndex = 2;
            this.btnSidsearch.Text = "Search";
            this.btnSidsearch.UseVisualStyleBackColor = true;
            this.btnSidsearch.Click += new System.EventHandler(this.btnSidsearch_Click);
            // 
            // txtsid_search
            // 
            this.txtsid_search.Location = new System.Drawing.Point(166, 53);
            this.txtsid_search.Name = "txtsid_search";
            this.txtsid_search.Size = new System.Drawing.Size(283, 27);
            this.txtsid_search.TabIndex = 1;
            this.txtsid_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsid_search_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Student ID";
            // 
            // dgvstudentlist
            // 
            this.dgvstudentlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvstudentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudentlist.Location = new System.Drawing.Point(25, 342);
            this.dgvstudentlist.Name = "dgvstudentlist";
            this.dgvstudentlist.RowHeadersWidth = 51;
            this.dgvstudentlist.RowTemplate.Height = 29;
            this.dgvstudentlist.Size = new System.Drawing.Size(1753, 549);
            this.dgvstudentlist.TabIndex = 3;
            this.dgvstudentlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvstudentlist_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::WinFormsApp1.Properties.Resources.home;
            this.label1.Location = new System.Drawing.Point(1590, 26);
            this.label1.MinimumSize = new System.Drawing.Size(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome";
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Location = new System.Drawing.Point(128, 26);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(50, 20);
            this.lblteacher.TabIndex = 6;
            this.lblteacher.Text = "label3";
            // 
            // StudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvstudentlist);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "StudentManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentManage";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudentlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox3;
        private Button btnSdelete;
        private Button btnSrefresh;
        private Button btnSupdate;
        private Button btnSadd;
        private RichTextBox txtsaddress;
        private TextBox txtsphone;
        private TextBox txtsgrade;
        private Label label14;
        private Label label13;
        private Label label12;
        private DateTimePicker dtpsbirth;
        private TextBox txtsname;
        private TextBox txtsid;
        private Label label11;
        private Label label8;
        private Label label6;
        private GroupBox groupBox4;
        private Label label16;
        private Button btnSidsearch;
        private TextBox txtsid_search;
        private Label label15;
        private DataGridView dgvstudentlist;
        private Label label1;
        private Label label2;
        private Label lblteacher;
    }
}