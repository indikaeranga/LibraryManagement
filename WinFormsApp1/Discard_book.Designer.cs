namespace WinFormsApp1
{
    partial class Discard_book
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtreason = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btndiscard = new System.Windows.Forms.Button();
            this.lblauthor = new System.Windows.Forms.Label();
            this.lblbn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblisbn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblbi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbookid = new System.Windows.Forms.Button();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvdiscard = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiscard)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtreason);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btndiscard);
            this.groupBox1.Controls.Add(this.lblauthor);
            this.groupBox1.Controls.Add(this.lblbn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblisbn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblbi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnbookid);
            this.groupBox1.Controls.Add(this.txtbookid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discard Book";
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(639, 59);
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(349, 66);
            this.txtreason.TabIndex = 13;
            this.txtreason.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Write the reason to discard";
            // 
            // btndiscard
            // 
            this.btndiscard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndiscard.ForeColor = System.Drawing.Color.Red;
            this.btndiscard.Location = new System.Drawing.Point(639, 136);
            this.btndiscard.Name = "btndiscard";
            this.btndiscard.Size = new System.Drawing.Size(114, 29);
            this.btndiscard.TabIndex = 11;
            this.btndiscard.Text = "Discard Book";
            this.btndiscard.UseVisualStyleBackColor = true;
            this.btndiscard.Click += new System.EventHandler(this.btndiscard_Click);
            // 
            // lblauthor
            // 
            this.lblauthor.AutoSize = true;
            this.lblauthor.Location = new System.Drawing.Point(454, 131);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(0, 20);
            this.lblauthor.TabIndex = 10;
            // 
            // lblbn
            // 
            this.lblbn.AutoSize = true;
            this.lblbn.Location = new System.Drawing.Point(454, 99);
            this.lblbn.Name = "lblbn";
            this.lblbn.Size = new System.Drawing.Size(0, 20);
            this.lblbn.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Book Name";
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Location = new System.Drawing.Point(454, 64);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(0, 20);
            this.lblisbn.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN";
            // 
            // lblbi
            // 
            this.lblbi.AutoSize = true;
            this.lblbi.Location = new System.Drawing.Point(454, 33);
            this.lblbi.Name = "lblbi";
            this.lblbi.Size = new System.Drawing.Size(0, 20);
            this.lblbi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book ID";
            // 
            // btnbookid
            // 
            this.btnbookid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbookid.ForeColor = System.Drawing.Color.Green;
            this.btnbookid.Location = new System.Drawing.Point(127, 94);
            this.btnbookid.Name = "btnbookid";
            this.btnbookid.Size = new System.Drawing.Size(94, 29);
            this.btnbookid.TabIndex = 2;
            this.btnbookid.Text = "Find Book";
            this.btnbookid.UseVisualStyleBackColor = true;
            this.btnbookid.Click += new System.EventHandler(this.btnbookid_Click);
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(127, 43);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(176, 27);
            this.txtbookid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book ID";
            // 
            // dgvdiscard
            // 
            this.dgvdiscard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdiscard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiscard.Location = new System.Drawing.Point(25, 255);
            this.dgvdiscard.Name = "dgvdiscard";
            this.dgvdiscard.RowHeadersWidth = 51;
            this.dgvdiscard.RowTemplate.Height = 29;
            this.dgvdiscard.Size = new System.Drawing.Size(1764, 636);
            this.dgvdiscard.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1391, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Table show data of all time discard history";
            // 
            // Discard_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvdiscard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label1);
            this.Name = "Discard_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discard_book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiscard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblteacher;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtbookid;
        private Label label2;
        private Button btnbookid;
        private Label lblauthor;
        private Label lblbn;
        private Label label9;
        private Label label8;
        private Label lblisbn;
        private Label label6;
        private Label lblbi;
        private Label label4;
        private Button btndiscard;
        private DataGridView dgvdiscard;
        private Label label5;
        private RichTextBox txtreason;
        private Label label7;
    }
}