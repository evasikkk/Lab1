using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabul tabul = new Tabul();
            double xn = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double h = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();

            tabul.tab(xn, xk, h, a);

            for (int i = 0; i < tabul.n; i++)
            {
                dataGridView1.Rows.Add(
                    Math.Round(tabul.xy[i, 0], 2).ToString(),
                    Math.Round(tabul.xy[i, 1], 3).ToString()
                );

                if (!double.IsNaN(tabul.xy[i, 1]) && !double.IsInfinity(tabul.xy[i, 1]))
                {
                    chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
                }
            }
        }
    }
}
