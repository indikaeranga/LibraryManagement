namespace WinFormsApp1
{
    partial class BookReportInventory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnisbndatesearch = new System.Windows.Forms.Button();
            this.dtptoisbn = new System.Windows.Forms.DateTimePicker();
            this.dtpfromsibn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsearchisbn = new System.Windows.Forms.Button();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvISBN = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnbookkdatesearch = new System.Windows.Forms.Button();
            this.dtpbookto = new System.Windows.Forms.DateTimePicker();
            this.dtpbookfrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnbookidsearch = new System.Windows.Forms.Button();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.btntodayaddinv = new System.Windows.Forms.Button();
            this.btnallbooks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvISBN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.lblteacher.Size = new System.Drawing.Size(75, 20);
            this.lblteacher.TabIndex = 1;
            this.lblteacher.Text = "lblteacher";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(25, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book ISBN Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnisbndatesearch);
            this.groupBox4.Controls.Add(this.dtptoisbn);
            this.groupBox4.Controls.Add(this.dtpfromsibn);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(455, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 99);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Date Range for Search";
            // 
            // btnisbndatesearch
            // 
            this.btnisbndatesearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnisbndatesearch.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnisbndatesearch.Location = new System.Drawing.Point(280, 42);
            this.btnisbndatesearch.Name = "btnisbndatesearch";
            this.btnisbndatesearch.Size = new System.Drawing.Size(94, 29);
            this.btnisbndatesearch.TabIndex = 4;
            this.btnisbndatesearch.Text = "Search";
            this.btnisbndatesearch.UseVisualStyleBackColor = true;
            this.btnisbndatesearch.Click += new System.EventHandler(this.btnisbndatesearch_Click);
            // 
            // dtptoisbn
            // 
            this.dtptoisbn.Location = new System.Drawing.Point(55, 62);
            this.dtptoisbn.Name = "dtptoisbn";
            this.dtptoisbn.Size = new System.Drawing.Size(215, 27);
            this.dtptoisbn.TabIndex = 3;
            // 
            // dtpfromsibn
            // 
            this.dtpfromsibn.Location = new System.Drawing.Point(55, 26);
            this.dtpfromsibn.Name = "dtpfromsibn";
            this.dtpfromsibn.Size = new System.Drawing.Size(215, 27);
            this.dtpfromsibn.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "From";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsearchisbn);
            this.groupBox3.Controls.Add(this.txtisbn);
            this.groupBox3.Location = new System.Drawing.Point(151, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 99);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter ISBN for Search";
            // 
            // btnsearchisbn
            // 
            this.btnsearchisbn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearchisbn.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnsearchisbn.Location = new System.Drawing.Point(170, 42);
            this.btnsearchisbn.Name = "btnsearchisbn";
            this.btnsearchisbn.Size = new System.Drawing.Size(94, 29);
            this.btnsearchisbn.TabIndex = 1;
            this.btnsearchisbn.Text = "Search";
            this.btnsearchisbn.UseVisualStyleBackColor = true;
            this.btnsearchisbn.Click += new System.EventHandler(this.btnsearchisbn_Click);
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(20, 44);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(125, 27);
            this.txtisbn.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Today Added";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "All ISBN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvISBN
            // 
            this.dgvISBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvISBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvISBN.Location = new System.Drawing.Point(12, 220);
            this.dgvISBN.Name = "dgvISBN";
            this.dgvISBN.RowHeadersWidth = 51;
            this.dgvISBN.RowTemplate.Height = 29;
            this.dgvISBN.Size = new System.Drawing.Size(1788, 671);
            this.dgvISBN.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.btntodayaddinv);
            this.groupBox2.Controls.Add(this.btnallbooks);
            this.groupBox2.Location = new System.Drawing.Point(921, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory Details";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnbookkdatesearch);
            this.groupBox6.Controls.Add(this.dtpbookto);
            this.groupBox6.Controls.Add(this.dtpbookfrom);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(433, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(414, 99);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select Date Range for Search";
            // 
            // btnbookkdatesearch
            // 
            this.btnbookkdatesearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbookkdatesearch.ForeColor = System.Drawing.Color.DeepPink;
            this.btnbookkdatesearch.Location = new System.Drawing.Point(296, 42);
            this.btnbookkdatesearch.Name = "btnbookkdatesearch";
            this.btnbookkdatesearch.Size = new System.Drawing.Size(94, 29);
            this.btnbookkdatesearch.TabIndex = 4;
            this.btnbookkdatesearch.Text = "Search";
            this.btnbookkdatesearch.UseVisualStyleBackColor = true;
            this.btnbookkdatesearch.Click += new System.EventHandler(this.btnbookkdatesearch_Click);
            // 
            // dtpbookto
            // 
            this.dtpbookto.Location = new System.Drawing.Point(64, 61);
            this.dtpbookto.Name = "dtpbookto";
            this.dtpbookto.Size = new System.Drawing.Size(219, 27);
            this.dtpbookto.TabIndex = 3;
            // 
            // dtpbookfrom
            // 
            this.dtpbookfrom.Location = new System.Drawing.Point(64, 25);
            this.dtpbookfrom.Name = "dtpbookfrom";
            this.dtpbookfrom.Size = new System.Drawing.Size(219, 27);
            this.dtpbookfrom.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "From";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnbookidsearch);
            this.groupBox5.Controls.Add(this.txtbookid);
            this.groupBox5.Location = new System.Drawing.Point(132, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 99);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "enter Book ID for Search";
            // 
            // btnbookidsearch
            // 
            this.btnbookidsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbookidsearch.ForeColor = System.Drawing.Color.DeepPink;
            this.btnbookidsearch.Location = new System.Drawing.Point(165, 43);
            this.btnbookidsearch.Name = "btnbookidsearch";
            this.btnbookidsearch.Size = new System.Drawing.Size(94, 29);
            this.btnbookidsearch.TabIndex = 1;
            this.btnbookidsearch.Text = "Search";
            this.btnbookidsearch.UseVisualStyleBackColor = true;
            this.btnbookidsearch.Click += new System.EventHandler(this.btnbookidsearch_Click);
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(18, 44);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(125, 27);
            this.txtbookid.TabIndex = 0;
            // 
            // btntodayaddinv
            // 
            this.btntodayaddinv.Location = new System.Drawing.Point(22, 92);
            this.btntodayaddinv.Name = "btntodayaddinv";
            this.btntodayaddinv.Size = new System.Drawing.Size(94, 29);
            this.btntodayaddinv.TabIndex = 1;
            this.btntodayaddinv.Text = "Today Added";
            this.btntodayaddinv.UseVisualStyleBackColor = true;
            this.btntodayaddinv.Click += new System.EventHandler(this.btntodayaddinv_Click);
            // 
            // btnallbooks
            // 
            this.btnallbooks.Location = new System.Drawing.Point(22, 47);
            this.btnallbooks.Name = "btnallbooks";
            this.btnallbooks.Size = new System.Drawing.Size(94, 29);
            this.btnallbooks.TabIndex = 0;
            this.btnallbooks.Text = "All Books";
            this.btnallbooks.UseVisualStyleBackColor = true;
            this.btnallbooks.Click += new System.EventHandler(this.btnallbooks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::WinFormsApp1.Properties.Resources.home;
            this.label2.Location = new System.Drawing.Point(1590, 26);
            this.label2.MinimumSize = new System.Drawing.Size(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BookReportInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.dgvISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label1);
            this.Name = "BookReportInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookReportInventory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvISBN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblteacher;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button btnisbndatesearch;
        private DateTimePicker dtptoisbn;
        private DateTimePicker dtpfromsibn;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private Button btnsearchisbn;
        private TextBox txtisbn;
        private Button button2;
        private Button button1;
        private DataGridView dgvISBN;
        private Label label2;
        private Button btntodayaddinv;
        private Button btnallbooks;
        private GroupBox groupBox6;
        private Button btnbookkdatesearch;
        private DateTimePicker dtpbookto;
        private DateTimePicker dtpbookfrom;
        private Label label6;
        private Label label5;
        private GroupBox groupBox5;
        private Button btnbookidsearch;
        private TextBox txtbookid;
    }
}