namespace Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(91, 319);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(64, 20);
            this.lbKetQua.TabIndex = 1;
            this.lbKetQua.Text = "Kết quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm trung bình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuyên ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(221, 40);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(176, 26);
            this.txtMaSV.TabIndex = 6;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(221, 233);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(176, 26);
            this.txtDiem.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(221, 89);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(176, 26);
            this.txtTen.TabIndex = 8;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(221, 132);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(245, 26);
            this.dtNgaySinh.TabIndex = 9;
            // 
            // cbChuyenNganh
            // 
            this.cbChuyenNganh.FormattingEnabled = true;
            this.cbChuyenNganh.Location = new System.Drawing.Point(221, 186);
            this.cbChuyenNganh.Name = "cbChuyenNganh";
            this.cbChuyenNganh.Size = new System.Drawing.Size(202, 28);
            this.cbChuyenNganh.TabIndex = 10;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(270, 286);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(88, 28);
            this.btnNhap.TabIndex = 11;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.cbChuyenNganh);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cbChuyenNganh;
        private System.Windows.Forms.Button btnNhap;
    }
}

