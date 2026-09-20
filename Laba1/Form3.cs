using System;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form3 : Form
    {
        private MatrixTask task = new MatrixTask();

        public Form3()
        {
            InitializeComponent();
        }

        // Кнопка для генерації матриці
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // Генеруємо масив із випадковими числами від 1 до 20
            task.GenerateMatrix(1, 20);

            int[,] matrix = task.GetMatrix();

            // Налаштовуємо DataGridView для показу 10 рядків та 7 стовпчиків
            dataGridViewMatrix.RowCount = 10;
            dataGridViewMatrix.ColumnCount = 7;

            // Задаємо підписи колонок (1..7)
            for (int j = 0; j < 7; j++)
            {
                dataGridViewMatrix.Columns[j].HeaderText = (j + 1).ToString();
                dataGridViewMatrix.Columns[j].Width = 40;
            }

            // Задаємо підписи рядків (1..10) та заповнюємо значення
            for (int i = 0; i < 10; i++)
            {
                dataGridViewMatrix.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < 7; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        // Кнопка для обчислення суми
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int sum = task.CalculateSumWithOddIndices();
            labelResult.Text = $"Сума елементів з обидвома непарними індексами: {sum}";
        }

        private void buttonGenerate_Click_1(object sender, EventArgs e)
        {
            // Генеруємо масив
            task.GenerateMatrix(1, 20);
            int[,] matrix = task.GetMatrix();

            // Налаштовуємо DataGridView під розмір 10х7
            dataGridViewMatrix.RowCount = 10;
            dataGridViewMatrix.ColumnCount = 7;

            // Підписи колонок (1..7)
            for (int j = 0; j < 7; j++)
            {
                dataGridViewMatrix.Columns[j].HeaderText = (j + 1).ToString();
                dataGridViewMatrix.Columns[j].Width = 40;
            }

            // Підписи рядків (1..10) та виведення значень
            for (int i = 0; i < 10; i++)
            {
                dataGridViewMatrix.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < 7; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            int sum = task.CalculateSumWithOddIndices();
            labelResult.Text = $"Сума: {sum}";
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}