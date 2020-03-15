namespace form
{
    partial class Form1
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
            this.lbTiep = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnpass = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lbHienThi = new System.Windows.Forms.Label();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTiep
            // 
            this.lbTiep.Location = new System.Drawing.Point(122, 152);
            this.lbTiep.Name = "lbTiep";
            this.lbTiep.Size = new System.Drawing.Size(75, 23);
            this.lbTiep.TabIndex = 1;
            this.lbTiep.Text = "Tiếp";
            this.lbTiep.UseVisualStyleBackColor = true;
            this.lbTiep.Click += new System.EventHandler(this.lbTiep_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(225, 152);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnpass
            // 
            this.btnpass.AutoSize = true;
            this.btnpass.Location = new System.Drawing.Point(57, 36);
            this.btnpass.Name = "btnpass";
            this.btnpass.Size = new System.Drawing.Size(53, 13);
            this.btnpass.TabIndex = 3;
            this.btnpass.Text = "Password";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(57, 83);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(47, 13);
            this.sd.TabIndex = 4;
            this.sd.Text = "Hiển Thị";
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Location = new System.Drawing.Point(12, 36);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(33, 13);
            this.lbNhap.TabIndex = 7;
            this.lbNhap.Text = "Nhập";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(146, 29);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '#';
            this.txtpass.Size = new System.Drawing.Size(168, 20);
            this.txtpass.TabIndex = 8;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(15, 152);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 11;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lbHienThi
            // 
            this.lbHienThi.AutoSize = true;
            this.lbHienThi.Location = new System.Drawing.Point(197, 83);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(0, 13);
            this.lbHienThi.TabIndex = 12;
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(203, 83);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(0, 13);
            this.lblHienThi.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 203);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.lbHienThi);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lbNhap);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.btnpass);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lbTiep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button lbTiep;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label btnpass;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lbHienThi;
        private System.Windows.Forms.Label lblHienThi;
    }
}

