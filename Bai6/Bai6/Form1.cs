using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = (double)numA.Value;
            double b = (double)numB.Value;
            double c = (double)numC.Value;
            txtThongTin.Text = "A = " + a + "\n";
            txtThongTin.Text += "B = " + b + "\n";
            txtThongTin.Text += "C = " + c + "\n";

            if (a == 0)
            {
                if (b == 0)
                {
                    txtThongTin.Text += "Phương trình vô nghiệm";
                    txtX1.Clear();
                    txtX2.Clear();
                }
                else
                {
                    double x = -c / b;
                    txtThongTin.Text += "Phương trình có nghiệm: x = " + x;
                    txtX1.Text = x.ToString();
                    txtX2.Clear();
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    txtThongTin.Text += "Phương trình vô nghiệm";
                    txtX1.Clear();
                    txtX2.Clear();
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    txtThongTin.Text += "Phương trình có nghiệm kép";
                    txtX1.Text = x.ToString("0.00");
                    txtX2.Text = x.ToString("0.00");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    txtThongTin.Text += "Phương trình có 2 nghiệm phân biệt";
                    txtX1.Text = x1.ToString("0.00");
                    txtX2.Text = x2.ToString("0.00");
                }
            }
        }
    }
}
