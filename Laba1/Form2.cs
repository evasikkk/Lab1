using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form2 : Form
    {
        // Створюємо екземпляр нашого класу для роботи з масивом прізвищ
        private ArrayTask task = new ArrayTask();

        public Form2()
        {
            InitializeComponent();
        }

        // Обробник натискання кнопки "Шукати"
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // 1. Перевіряємо, чи ввів користувач літеру для пошуку
            if (string.IsNullOrWhiteSpace(textBoxLetter.Text))
            {
                MessageBox.Show("Будь ласка, введіть літеру для пошуку!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Беремо першу літеру з поля введення
            char searchLetter = textBoxLetter.Text[0];

            // 2. Зчитуємо 5 прізвищ з текстових полів у масив
            task.surnames[0] = textBox1.Text;
            task.surnames[1] = textBox2.Text;
            task.surnames[2] = textBox3.Text;
            task.surnames[3] = textBox4.Text;
            task.surnames[4] = textBox5.Text;

            // 3. Отримуємо відфільтрований список прізвищ з нашого класу
            List<string> foundSurnames = task.GetSurnamesStartingWith(searchLetter);

            // 4. Очищаємо список результатів перед виведенням нових даних
            listBoxResult.Items.Clear();

            // 5. Виводим результати у ListBox
            if (foundSurnames.Count > 0)
            {
                foreach (string surname in foundSurnames)
                {
                    listBoxResult.Items.Add(surname);
                }
            }
            else
            {
                listBoxResult.Items.Add($"Прізвищ на літеру '{searchLetter}' не знайдено.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}