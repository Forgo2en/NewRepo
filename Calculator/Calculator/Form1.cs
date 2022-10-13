using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double n;
        double v;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n = 0;
                v = 0;
                double s = Double.Parse(textBox1.Text);
                double p = Double.Parse(textBox2.Text);
                int k = int.Parse(textBox3.Text);
                if (p < 40000)
                {
                    if (radioButton1.Checked)
                    {
                        v = 600 + 600 * k;
                    }
                    else if (radioButton2.Checked)
                    {
                        v = 600 + 1200 * k;
                    }
                    n = 0.13 * (s - v);
                    if (n <= 0)
                    {
                        n = 0;
                        textBox5.Text = n.ToString();
                    }
                    else
                    {
                        textBox5.Text = n.ToString();
                    }
                }
                else
                {
                    n = 0.13 * s;
                }
            }
            catch
            {
                MessageBox.Show("Некорректное значение");
            }
        }
    }
}
