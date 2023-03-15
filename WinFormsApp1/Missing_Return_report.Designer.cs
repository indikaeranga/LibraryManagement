namespace WinFormsApp1
{
    partial class Missing_Return_report
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
            this.btnall = new System.Windows.Forms.Button();
            this.dgvall = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvall)).BeginInit();
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
            this.groupBox1.Controls.Add(this.btnall);
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Missing and Return Books";
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(47, 54);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(94, 29);
            this.btnall.TabIndex = 0;
            this.btnall.Text = "All Books";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // dgvall
            // 
            this.dgvall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvall.Location = new System.Drawing.Point(25, 232);
            this.dgvall.Name = "dgvall";
            this.dgvall.RowHeadersWidth = 51;
            this.dgvall.RowTemplate.Height = 29;
            this.dgvall.Size = new System.Drawing.Size(1765, 659);
            this.dgvall.TabIndex = 4;
            // 
            // Missing_Return_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1812, 903);
            this.Controls.Add(this.dgvall);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.label1);
            this.Name = "Missing_Return_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missing_Return_report";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblteacher;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnall;
        private DataGridView dgvall;
    }
}