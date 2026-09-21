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
            try
            {
                double xn = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                double xk = Convert.ToDouble(textBox3.Text.Replace('.', ','));   // було textBox2
                double h = Convert.ToDouble(textBox2.Text.Replace('.', ','));   // було textBox3
                double a = Convert.ToDouble(textBox4.Text.Replace('.', ','));

                MessageBox.Show($"xn={xn}, xk={xk}, h={h}, a={a}");

                if (h <= 0)
                {
                    MessageBox.Show("Крок h повинен бути більше 0!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Tabul tabul = new Tabul();

                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();

                tabul.tab(xn, xk, h, a);

                for (int i = 0; i < tabul.n; i++)
                {
                    double xVal = tabul.xy[i, 0];
                    double yVal = tabul.xy[i, 1];

                    // Перевіряємо чи значення y є коректним числом
                    string yStr = (double.IsNaN(yVal) || double.IsInfinity(yVal))
                                  ? "не існує"
                                  : Math.Round(yVal, 3).ToString();

                    dataGridView1.Rows.Add(Math.Round(xVal, 2).ToString(), yStr);

                    // Додаємо на графік лише існуючі точки
                    if (!double.IsNaN(yVal) && !double.IsInfinity(yVal))
                    {
                        chart1.Series[0].Points.AddXY(xVal, yVal);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Будь ласка, введіть коректні числові значення! Помилка: {ex.Message}", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void одновимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
