using System;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbChuyenNganh.Items.Add("CNTT");
            cbChuyenNganh.Items.Add("HTTTQL");
            cbChuyenNganh.Items.Add("Ngân hàng");
            cbChuyenNganh.Items.Add("Tài chính");

            cbChuyenNganh.SelectedIndex = 0;
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            string ma = txtMaSV.Text;
            string ten = txtTen.Text;
            DateTime ns = dtNgaySinh.Value;
            string cn = cbChuyenNganh.Text;

            double diem;
            if (!double.TryParse(txtDiem.Text, out diem))
            {
                MessageBox.Show("Điểm không hợp lệ");
                return;
            }
            SinhVienCN sv = new SinhVienCN(ma, ten, ns, cn, diem);
            lbKetQua.Text = sv.getInfor();
        }
    }
}