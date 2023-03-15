namespace WinFormsApp1
{
    partial class Issue_book_report
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
            this.btnhistory = new System.Windows.Forms.Button();
            this.btntoday = new System.Windows.Forms.Button();
            this.btnall = new System.Windows.Forms.Button();
            this.dgvissued = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndatesearch = new System.Windows.Forms.Button();
            this.btnto = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvissued)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnhistory);
            this.groupBox1.Controls.Add(this.btntoday);
            this.groupBox1.Controls.Add(this.btnall);
            this.groupBox1.Location = new System.Drawing.Point(25, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnhistory
            // 
            this.btnhistory.Location = new System.Drawing.Point(56, 20);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(130, 29);
            this.btnhistory.TabIndex = 2;
            this.btnhistory.Text = "All History";
            this.btnhistory.UseVisualStyleBackColor = true;
            this.btnhistory.Click += new System.EventHandler(this.btnhistory_Click);
            // 
            // btntoday
            // 
            this.btntoday.Location = new System.Drawing.Point(54, 100);
            this.btntoday.Name = "btntoday";
            this.btntoday.Size = new System.Drawing.Size(132, 29);
            this.btntoday.TabIndex = 1;
            this.btntoday.Text = "Today Issued";
            this.btntoday.UseVisualStyleBackColor = true;
            this.btntoday.Click += new System.EventHandler(this.btntoday_Click);
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(54, 60);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(132, 29);
            this.btnall.TabIndex = 0;
            this.btnall.Text = "Issued Books";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvissued
            // 
            this.dgvissued.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvissued.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvissued.Location = new System.Drawing.Point(12, 220);
            this.dgvissued.Name = "dgvissued";
            this.dgvissued.RowHeadersWidth = 51;
            this.dgvissued.RowTemplate.Height = 29;
            this.dgvissued.Size = new System.Drawing.Size(1788, 671);
            this.dgvissued.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndatesearch);
            this.groupBox2.Controls.Add(this.btnto);
            this.groupBox2.Controls.Add(this.dtpfrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(293, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Date Range";
            // 
            // btndatesearch
            // 
            this.btndatesearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndatesearch.ForeColor = System.Drawing.Color.Magenta;
            this.btndatesearch.Location = new System.Drawing.Point(360, 61);
            this.btndatesearch.Name = "btndatesearch";
            this.btndatesearch.Size = new System.Drawing.Size(94, 29);
            this.btndatesearch.TabIndex = 4;
            this.btndatesearch.Text = "Search";
            this.btndatesearch.UseVisualStyleBackColor = true;
            this.btndatesearch.Click += new System.EventHandler(this.btndatesearch_Click);
            // 
            // btnto
            // 
            this.btnto.Location = new System.Drawing.Point(82, 83);
            this.btnto.Name = "btnto";
            this.btnto.Size = new System.Drawing.Size(250, 27);
            this.btnto.TabIndex = 3;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Location = new System.Drawing.Point(82, 36);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(250, 27);
            this.dtpfrom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::WinFormsApp1.Properties.Resources.home;
            this.label4.Location = new System.Drawing.Point(1590, 26);
            this.label4.MinimumSize = new System.Drawing.Size(32, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 32);
            this.label4.TabIndex = 4;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Issue_book_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvissued);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label1);
            this.Name = "Issue_book_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue_book_report";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvissued)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblteacher;
        private GroupBox groupBox1;
        private DataGridView dgvissued;
        private Button btntoday;
        private Button btnall;
        private GroupBox groupBox2;
        private Button btndatesearch;
        private DateTimePicker btnto;
        private DateTimePicker dtpfrom;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnhistory;
    }
}