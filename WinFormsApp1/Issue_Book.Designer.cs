namespace WinFormsApp1
{
    partial class Issue_Book
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblteacher = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnissue = new System.Windows.Forms.Button();
            this.btnverify = new System.Windows.Forms.Button();
            this.lblstudent = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.dtpdue = new System.Windows.Forms.DateTimePicker();
            this.dtpissue = new System.Windows.Forms.DateTimePicker();
            this.txtstdid = new System.Windows.Forms.TextBox();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvissueBK_STD = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvreturn = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvissueBK_STD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::WinFormsApp1.Properties.Resources.home;
            this.label1.Location = new System.Drawing.Point(1590, 26);
            this.label1.MinimumSize = new System.Drawing.Size(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome ";
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Location = new System.Drawing.Point(125, 25);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(50, 20);
            this.lblteacher.TabIndex = 2;
            this.lblteacher.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnissue);
            this.groupBox1.Controls.Add(this.btnverify);
            this.groupBox1.Controls.Add(this.lblstudent);
            this.groupBox1.Controls.Add(this.lblBook);
            this.groupBox1.Controls.Add(this.dtpdue);
            this.groupBox1.Controls.Add(this.dtpissue);
            this.groupBox1.Controls.Add(this.txtstdid);
            this.groupBox1.Controls.Add(this.txtbookid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 272);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnissue
            // 
            this.btnissue.Location = new System.Drawing.Point(284, 221);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(94, 29);
            this.btnissue.TabIndex = 11;
            this.btnissue.Text = "Issue Book";
            this.btnissue.UseVisualStyleBackColor = true;
            this.btnissue.Click += new System.EventHandler(this.btnissue_Click);
            // 
            // btnverify
            // 
            this.btnverify.Location = new System.Drawing.Point(128, 221);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(94, 29);
            this.btnverify.TabIndex = 10;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Location = new System.Drawing.Point(412, 94);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(50, 20);
            this.lblstudent.TabIndex = 9;
            this.lblstudent.Text = "label8";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(412, 53);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(50, 20);
            this.lblBook.TabIndex = 8;
            this.lblBook.Text = "label7";
            // 
            // dtpdue
            // 
            this.dtpdue.Location = new System.Drawing.Point(128, 174);
            this.dtpdue.Name = "dtpdue";
            this.dtpdue.Size = new System.Drawing.Size(250, 27);
            this.dtpdue.TabIndex = 7;
            // 
            // dtpissue
            // 
            this.dtpissue.Location = new System.Drawing.Point(128, 132);
            this.dtpissue.Name = "dtpissue";
            this.dtpissue.Size = new System.Drawing.Size(250, 27);
            this.dtpissue.TabIndex = 6;
            // 
            // txtstdid
            // 
            this.txtstdid.Location = new System.Drawing.Point(128, 87);
            this.txtstdid.Name = "txtstdid";
            this.txtstdid.Size = new System.Drawing.Size(250, 27);
            this.txtstdid.TabIndex = 5;
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(128, 46);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(250, 27);
            this.txtbookid.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Issue Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book ID";
            // 
            // dgvissueBK_STD
            // 
            this.dgvissueBK_STD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvissueBK_STD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvissueBK_STD.Location = new System.Drawing.Point(25, 407);
            this.dgvissueBK_STD.Name = "dgvissueBK_STD";
            this.dgvissueBK_STD.RowHeadersWidth = 51;
            this.dgvissueBK_STD.RowTemplate.Height = 29;
            this.dgvissueBK_STD.Size = new System.Drawing.Size(851, 484);
            this.dgvissueBK_STD.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(378, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Books issue for this student previously but not return yet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(912, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Student Book History / Return books only";
            // 
            // dgvreturn
            // 
            this.dgvreturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreturn.Location = new System.Drawing.Point(912, 107);
            this.dgvreturn.Name = "dgvreturn";
            this.dgvreturn.RowHeadersWidth = 51;
            this.dgvreturn.RowTemplate.Height = 29;
            this.dgvreturn.Size = new System.Drawing.Size(871, 784);
            this.dgvreturn.TabIndex = 7;
            // 
            // Issue_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.dgvreturn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvissueBK_STD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Issue_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue_Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvissueBK_STD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblteacher;
        private GroupBox groupBox1;
        private Button btnissue;
        private Button btnverify;
        private Label lblstudent;
        private Label lblBook;
        private DateTimePicker dtpdue;
        private DateTimePicker dtpissue;
        private TextBox txtstdid;
        private TextBox txtbookid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgvissueBK_STD;
        private Label label7;
        private Label label8;
        private DataGridView dgvreturn;
    }
}