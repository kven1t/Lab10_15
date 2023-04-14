using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "результат:" + Environment.NewLine;
            double x1 = x;
            while (x <= (xk + dx / 2))
            {
                double y = ((Math.Pow(10, -3) * Math.Pow(Math.Abs(x1), (5 / 2))) + Math.Log(Math.Abs(x1 + b)));

                textBox5.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                this.chart1.Series[0].Points.AddXY(x, y);
                x = x + dx;
            }
        }
    }
}
