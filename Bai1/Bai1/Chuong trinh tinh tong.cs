using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(texta, "Nhap so nguyen a");
            toolTip1.SetToolTip(textb, "Nhap so nguyen b");
        }
        private void Tong(object sender, EventArgs e)
        {
            if (texta.Text == "" || textb.Text == "")
            {
                MessageBox.Show("Vui long nhap du a va b");
                return;
            }

            int a = int.Parse(texta.Text);
            int b = int.Parse(textb.Text);
            int tong = 0;

            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                    tong += i;
            }
            else
            {
                for (int i = b; i <= a; i++)
                    tong += i;
            }

            labelTong.Text = "Tong cac so tu " + a + " den " + b + " = " + tong;
        }
        private void Again(object sender, EventArgs e)
        {
            texta.Clear();
            textb.Clear();
            labelTong.Text = "Tong la: ";
            texta.Focus();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}

