namespace WinFormsApp1
{
    partial class Return_Book
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpreturn = new System.Windows.Forms.DateTimePicker();
            this.btncheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtissue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbook = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpreturnbybookid = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnaccept = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtstdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvreturn = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Location = new System.Drawing.Point(125, 25);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(50, 20);
            this.lblteacher.TabIndex = 1;
            this.lblteacher.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::WinFormsApp1.Properties.Resources.home;
            this.label2.Location = new System.Drawing.Point(1590, 26);
            this.label2.MinimumSize = new System.Drawing.Size(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpreturn);
            this.groupBox1.Controls.Add(this.btncheck);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtissue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(587, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retuns check by Issued ID";
            // 
            // dtpreturn
            // 
            this.dtpreturn.Location = new System.Drawing.Point(164, 107);
            this.dtpreturn.Name = "dtpreturn";
            this.dtpreturn.Size = new System.Drawing.Size(224, 27);
            this.dtpreturn.TabIndex = 5;
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(164, 159);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(94, 29);
            this.btncheck.TabIndex = 5;
            this.btncheck.Text = "Accept";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Return Date";
            // 
            // txtissue
            // 
            this.txtissue.Location = new System.Drawing.Point(164, 55);
            this.txtissue.Name = "txtissue";
            this.txtissue.Size = new System.Drawing.Size(224, 27);
            this.txtissue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Issued ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book ID";
            // 
            // txtbook
            // 
            this.txtbook.Location = new System.Drawing.Point(168, 52);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(224, 27);
            this.txtbook.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpreturnbybookid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnaccept);
            this.groupBox2.Controls.Add(this.txtbook);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(25, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return check by Book ID";
            // 
            // dtpreturnbybookid
            // 
            this.dtpreturnbybookid.Location = new System.Drawing.Point(168, 104);
            this.dtpreturnbybookid.Name = "dtpreturnbybookid";
            this.dtpreturnbybookid.Size = new System.Drawing.Size(224, 27);
            this.dtpreturnbybookid.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Return Date";
            // 
            // btnaccept
            // 
            this.btnaccept.Location = new System.Drawing.Point(168, 156);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(94, 29);
            this.btnaccept.TabIndex = 6;
            this.btnaccept.Text = "Accept";
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Controls.Add(this.txtstdit);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(1236, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 228);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check Books to return by Student ID";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(173, 102);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(94, 29);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtstdit
            // 
            this.txtstdit.Location = new System.Drawing.Point(173, 48);
            this.txtstdit.Name = "txtstdit";
            this.txtstdit.Size = new System.Drawing.Size(235, 27);
            this.txtstdit.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(504, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "OR";
            // 
            // dgvreturn
            // 
            this.dgvreturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreturn.Location = new System.Drawing.Point(25, 347);
            this.dgvreturn.Name = "dgvreturn";
            this.dgvreturn.RowHeadersWidth = 51;
            this.dgvreturn.RowTemplate.Height = 29;
            this.dgvreturn.Size = new System.Drawing.Size(1760, 544);
            this.dgvreturn.TabIndex = 7;
            this.dgvreturn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvreturn_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1236, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "If data available double click row for select";
            // 
            // Return_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvreturn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label1);
            this.Name = "Return_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return_Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblteacher;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpreturn;
        private TextBox txtbook;
        private TextBox txtissue;
        private Label label5;
        private Button btncheck;
        private GroupBox groupBox2;
        private DateTimePicker dtpreturnbybookid;
        private Label label6;
        private Button btnaccept;
        private GroupBox groupBox3;
        private Button btnsearch;
        private TextBox txtstdit;
        private Label label7;
        private Label label8;
        private DataGridView dgvreturn;
        private Label label9;
    }
}