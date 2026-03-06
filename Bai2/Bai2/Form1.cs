using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nhập n");
                return;
            }
            n = int.Parse(textBox1.Text);
            a = new int[n];
            string s = "";
            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(1, 101);
                s += a[i] + " ";
            }
            label2.Text = "Dãy số: " + s;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }

            label3.Text = "Tổng: " + tong;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Array.Sort(a);
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += a[i] + " ";
            }
            label4.Text = "Sắp xếp: " + s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "Dãy số:";
            label3.Text = "Tổng dãy số:";
            label4.Text = "Sắp xếp:";
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}