namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnte = new System.Windows.Forms.Button();
            this.txtpass_te = new System.Windows.Forms.TextBox();
            this.txtname_te = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnte);
            this.groupBox2.Controls.Add(this.txtpass_te);
            this.groupBox2.Controls.Add(this.txtname_te);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(631, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 409);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Form";
            // 
            // btnte
            // 
            this.btnte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnte.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnte.Location = new System.Drawing.Point(147, 252);
            this.btnte.Name = "btnte";
            this.btnte.Size = new System.Drawing.Size(109, 29);
            this.btnte.TabIndex = 4;
            this.btnte.Text = "Login";
            this.btnte.UseVisualStyleBackColor = true;
            this.btnte.Click += new System.EventHandler(this.btnte_Click_1);
            // 
            // txtpass_te
            // 
            this.txtpass_te.Location = new System.Drawing.Point(147, 172);
            this.txtpass_te.Name = "txtpass_te";
            this.txtpass_te.Size = new System.Drawing.Size(182, 27);
            this.txtpass_te.TabIndex = 3;
            // 
            // txtname_te
            // 
            this.txtname_te.Location = new System.Drawing.Point(147, 111);
            this.txtname_te.Name = "txtname_te";
            this.txtname_te.Size = new System.Drawing.Size(182, 27);
            this.txtname_te.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(120, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 75);
            this.label1.TabIndex = 7;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Image = global::WinFormsApp1.Properties.Resources.Untitled_1;
            this.label2.Location = new System.Drawing.Point(128, 162);
            this.label2.MinimumSize = new System.Drawing.Size(400, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 400);
            this.label2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(942, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Version 1.0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(631, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Developed by : Indika Eranga Harischandra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 655);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox2;
        private Button btnte;
        private TextBox txtpass_te;
        private TextBox txtname_te;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
    }
}