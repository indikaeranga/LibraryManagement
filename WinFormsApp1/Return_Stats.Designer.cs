namespace WinFormsApp1
{
    partial class Return_Stats
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnatr = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvreturn = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnatr);
            this.groupBox1.Location = new System.Drawing.Point(25, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return Today";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnatr
            // 
            this.btnatr.Location = new System.Drawing.Point(57, 33);
            this.btnatr.Name = "btnatr";
            this.btnatr.Size = new System.Drawing.Size(141, 29);
            this.btnatr.TabIndex = 0;
            this.btnatr.Text = "All Time Return";
            this.btnatr.UseVisualStyleBackColor = true;
            this.btnatr.Click += new System.EventHandler(this.btnatr_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Controls.Add(this.dtpto);
            this.groupBox2.Controls.Add(this.dtpfrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(310, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Date";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.ForeColor = System.Drawing.Color.Magenta;
            this.btnsearch.Location = new System.Drawing.Point(376, 53);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(94, 29);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dtpto
            // 
            this.dtpto.Location = new System.Drawing.Point(87, 76);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(250, 27);
            this.dtpto.TabIndex = 3;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Location = new System.Drawing.Point(87, 35);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(250, 27);
            this.dtpfrom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "From";
            // 
            // dgvreturn
            // 
            this.dgvreturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreturn.Location = new System.Drawing.Point(12, 220);
            this.dgvreturn.Name = "dgvreturn";
            this.dgvreturn.RowHeadersWidth = 51;
            this.dgvreturn.RowTemplate.Height = 29;
            this.dgvreturn.Size = new System.Drawing.Size(1788, 671);
            this.dgvreturn.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::WinFormsApp1.Properties.Resources.home;
            this.label4.Location = new System.Drawing.Point(1590, 26);
            this.label4.MinimumSize = new System.Drawing.Size(32, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 32);
            this.label4.TabIndex = 5;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Return_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvreturn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label1);
            this.Name = "Return_Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return_Stats";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblteacher;
        private GroupBox groupBox1;
        private Button btnatr;
        private GroupBox groupBox2;
        private Button btnsearch;
        private DateTimePicker dtpto;
        private DateTimePicker dtpfrom;
        private Label label3;
        private Label label2;
        private Button button1;
        private DataGridView dgvreturn;
        private Label label4;
    }
}