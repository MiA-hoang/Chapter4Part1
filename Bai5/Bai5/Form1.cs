using System;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        double so1, so2;
        string pheptoan;
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "1";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "2";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "3";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "4";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "5";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "6";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "7";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "8";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "9";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "0";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtHienThi.Text);
            pheptoan = "+";
            txtHienThi.Clear();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtHienThi.Text);
            pheptoan = "-";
            txtHienThi.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtHienThi.Text);
            pheptoan = "*";
            txtHienThi.Clear();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtHienThi.Text);
            pheptoan = "/";
            txtHienThi.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtHienThi.Text == "")
            {
                MessageBox.Show("Chưa nhập số");
                return;
            }
            so2 = double.Parse(txtHienThi.Text);
            double kq = so2;

            if (pheptoan == "+") kq = so1 + so2;
            else if (pheptoan == "-") kq = so1 - so2;
            else if (pheptoan == "*") kq = so1 * so2;
            else if (pheptoan == "/") kq = so1 / so2;

            txtHienThi.Text = kq.ToString();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            txtHienThi.Clear();
        }
    }
}