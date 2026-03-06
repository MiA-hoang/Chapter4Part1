namespace Bai3
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
            this.components = new System.ComponentModel.Container();
            this.MaHang = new System.Windows.Forms.Label();
            this.DonGia = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TongTien = new System.Windows.Forms.Label();
            this.TxtTong = new System.Windows.Forms.TextBox();
            this.GiamGia = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ThucHien = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // MaHang
            // 
            this.MaHang.AutoSize = true;
            this.MaHang.Location = new System.Drawing.Point(82, 66);
            this.MaHang.Name = "MaHang";
            this.MaHang.Size = new System.Drawing.Size(71, 20);
            this.MaHang.TabIndex = 0;
            this.MaHang.Text = "Mã hàng";
            // 
            // DonGia
            // 
            this.DonGia.AutoSize = true;
            this.DonGia.Location = new System.Drawing.Point(82, 124);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(64, 20);
            this.DonGia.TabIndex = 1;
            this.DonGia.Text = "Đơn giá";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSize = true;
            this.SoLuong.Location = new System.Drawing.Point(82, 183);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(72, 20);
            this.SoLuong.TabIndex = 2;
            this.SoLuong.Text = "Số lượng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 26);
            this.textBox3.TabIndex = 5;
            // 
            // TongTien
            // 
            this.TongTien.AutoSize = true;
            this.TongTien.Location = new System.Drawing.Point(487, 101);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(75, 20);
            this.TongTien.TabIndex = 6;
            this.TongTien.Text = "Tổng tiền";
            // 
            // TxtTong
            // 
            this.TxtTong.Location = new System.Drawing.Point(592, 101);
            this.TxtTong.Name = "TxtTong";
            this.TxtTong.Size = new System.Drawing.Size(100, 26);
            this.TxtTong.TabIndex = 7;
            // 
            // GiamGia
            // 
            this.GiamGia.AutoSize = true;
            this.GiamGia.Location = new System.Drawing.Point(86, 255);
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.Size = new System.Drawing.Size(98, 24);
            this.GiamGia.TabIndex = 8;
            this.GiamGia.Text = "Giảm giá";
            this.GiamGia.UseVisualStyleBackColor = true;
            this.GiamGia.CheckedChanged += new System.EventHandler(this.GiamGia_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(252, 255);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5%";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(375, 255);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "10%";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ThucHien
            // 
            this.ThucHien.Location = new System.Drawing.Point(182, 362);
            this.ThucHien.Name = "ThucHien";
            this.ThucHien.Size = new System.Drawing.Size(113, 35);
            this.ThucHien.TabIndex = 11;
            this.ThucHien.Text = "Thực hiện";
            this.ThucHien.UseVisualStyleBackColor = true;
            this.ThucHien.Click += new System.EventHandler(this.ThucHien_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(349, 362);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(92, 35);
            this.Thoat.TabIndex = 12;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.ThucHien);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.GiamGia);
            this.Controls.Add(this.TxtTong);
            this.Controls.Add(this.TongTien);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.MaHang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaHang;
        private System.Windows.Forms.Label DonGia;
        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label TongTien;
        private System.Windows.Forms.TextBox TxtTong;
        private System.Windows.Forms.CheckBox GiamGia;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button ThucHien;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

