namespace WinFormsApp1
{
    partial class Missing_Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblteacher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsearchbybookid = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbookidsearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtstdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvreturn = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblissue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtremark = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblstdid = new System.Windows.Forms.Label();
            this.lblbookid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbrep = new System.Windows.Forms.RadioButton();
            this.rdbpay = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreturn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Location = new System.Drawing.Point(128, 26);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(50, 20);
            this.lblteacher.TabIndex = 1;
            this.lblteacher.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::WinFormsApp1.Properties.Resources.home;
            this.label3.Location = new System.Drawing.Point(1590, 26);
            this.label3.MinimumSize = new System.Drawing.Size(32, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 32);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsearchbybookid);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtbookidsearch);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Controls.Add(this.txtstdit);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(25, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 228);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check Books to Return";
            // 
            // btnsearchbybookid
            // 
            this.btnsearchbybookid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearchbybookid.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnsearchbybookid.Location = new System.Drawing.Point(354, 124);
            this.btnsearchbybookid.Name = "btnsearchbybookid";
            this.btnsearchbybookid.Size = new System.Drawing.Size(94, 29);
            this.btnsearchbybookid.TabIndex = 7;
            this.btnsearchbybookid.Text = "Search";
            this.btnsearchbybookid.UseVisualStyleBackColor = true;
            this.btnsearchbybookid.Click += new System.EventHandler(this.btnsearchbybookid_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "OR";
            // 
            // txtbookidsearch
            // 
            this.txtbookidsearch.Location = new System.Drawing.Point(133, 126);
            this.txtbookidsearch.Name = "txtbookidsearch";
            this.txtbookidsearch.Size = new System.Drawing.Size(182, 27);
            this.txtbookidsearch.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Book ID";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.ForeColor = System.Drawing.Color.Magenta;
            this.btnsearch.Location = new System.Drawing.Point(354, 46);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(94, 29);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtstdit
            // 
            this.txtstdit.Location = new System.Drawing.Point(133, 48);
            this.txtstdit.Name = "txtstdit";
            this.txtstdit.Size = new System.Drawing.Size(182, 27);
            this.txtstdit.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student ID";
            // 
            // dgvreturn
            // 
            this.dgvreturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreturn.Location = new System.Drawing.Point(25, 347);
            this.dgvreturn.Name = "dgvreturn";
            this.dgvreturn.RowHeadersWidth = 51;
            this.dgvreturn.RowTemplate.Height = 29;
            this.dgvreturn.Size = new System.Drawing.Size(1761, 544);
            this.dgvreturn.TabIndex = 7;
            this.dgvreturn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvreturn_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "If data available double click row for select";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnrefresh.ForeColor = System.Drawing.Color.Green;
            this.btnrefresh.Location = new System.Drawing.Point(446, 305);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(128, 29);
            this.btnrefresh.TabIndex = 9;
            this.btnrefresh.Text = "Refresh Fields";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblissue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnsubmit);
            this.groupBox1.Controls.Add(this.txtremark);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.lblstdid);
            this.groupBox1.Controls.Add(this.lblbookid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdbrep);
            this.groupBox1.Controls.Add(this.rdbpay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(680, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1106, 228);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Missing Book Update";
            // 
            // lblissue
            // 
            this.lblissue.AutoSize = true;
            this.lblissue.Location = new System.Drawing.Point(113, 50);
            this.lblissue.Name = "lblissue";
            this.lblissue.Size = new System.Drawing.Size(0, 20);
            this.lblissue.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Issue ID";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnsubmit.Location = new System.Drawing.Point(433, 176);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(94, 29);
            this.btnsubmit.TabIndex = 10;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(433, 62);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(637, 91);
            this.txtremark.TabIndex = 9;
            this.txtremark.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Remark";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(162, 187);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(125, 27);
            this.txtprice.TabIndex = 7;
            // 
            // lblstdid
            // 
            this.lblstdid.AutoSize = true;
            this.lblstdid.Location = new System.Drawing.Point(162, 122);
            this.lblstdid.Name = "lblstdid";
            this.lblstdid.Size = new System.Drawing.Size(0, 20);
            this.lblstdid.TabIndex = 6;
            // 
            // lblbookid
            // 
            this.lblbookid.AutoSize = true;
            this.lblbookid.Location = new System.Drawing.Point(162, 85);
            this.lblbookid.Name = "lblbookid";
            this.lblbookid.Size = new System.Drawing.Size(0, 20);
            this.lblbookid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // rdbrep
            // 
            this.rdbrep.AutoSize = true;
            this.rdbrep.Checked = true;
            this.rdbrep.Location = new System.Drawing.Point(113, 152);
            this.rdbrep.Name = "rdbrep";
            this.rdbrep.Size = new System.Drawing.Size(83, 24);
            this.rdbrep.TabIndex = 3;
            this.rdbrep.TabStop = true;
            this.rdbrep.Text = "Replace";
            this.rdbrep.UseVisualStyleBackColor = true;
            // 
            // rdbpay
            // 
            this.rdbpay.AutoSize = true;
            this.rdbpay.Location = new System.Drawing.Point(37, 152);
            this.rdbpay.Name = "rdbpay";
            this.rdbpay.Size = new System.Drawing.Size(58, 24);
            this.rdbpay.TabIndex = 2;
            this.rdbpay.Text = "Paid";
            this.rdbpay.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book ID";
            // 
            // Missing_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dgvreturn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label1);
            this.Name = "Missing_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missing_Books";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreturn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblteacher;
        private Label label3;
        private GroupBox groupBox3;
        private Button btnsearchbybookid;
        private Label label11;
        private TextBox txtbookidsearch;
        private Label label10;
        private Button btnsearch;
        private TextBox txtstdit;
        private Label label7;
        private DataGridView dgvreturn;
        private Label label9;
        private Button btnrefresh;
        private GroupBox groupBox1;
        private RichTextBox txtremark;
        private Label label12;
        private TextBox txtprice;
        private Label lblstdid;
        private Label lblbookid;
        private Label label5;
        private RadioButton rdbrep;
        private RadioButton rdbpay;
        private Label label4;
        private Label label2;
        private Button btnsubmit;
        private Label lblissue;
        private Label label6;
    }
}