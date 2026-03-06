using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxtTong.ReadOnly = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }
        private void DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void GiamGia_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = GiamGia.Checked;
            radioButton2.Visible = GiamGia.Checked;
        }
        private void ThucHien_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Đơn giá và Số lượng");
                return;
            }

            int dongia = int.Parse(textBox2.Text);
            int soluong = int.Parse(textBox3.Text);

            double tong = dongia * soluong;

            if (GiamGia.Checked)
            {
                if (radioButton1.Checked)
                    tong = tong * 0.95;
                else if (radioButton2.Checked)
                    tong = tong * 0.90;
            }

            TxtTong.Text = tong.ToString();
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
