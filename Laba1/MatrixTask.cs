using System;

namespace Laba1
{
    internal class MatrixTask
    {
        // Двовимірний масив 10 рядків на 7 стовпчиків
        private int[,] array = new int[10, 7];
        private Random random = new Random();

        // Метод для заповнення матриці випадковими числами від min до max
        public void GenerateMatrix(int min, int max)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    array[i, j] = random.Next(min, max + 1);
                }
            }
        }

        // Повертає згенерований масив для виведення в DataGridView
        public int[,] GetMatrix()
        {
            return array;
        }

        // Знаходження суми елементів, які мають обидва непарні індекси (в нумерації від 1: 1, 3, 5...)
        public int CalculateSumWithOddIndices()
        {
            int sum = 0;

            // Індекси 0, 2, 4, 6... відповідають 1, 3, 5, 7... за людською нумерацією (1..10, 1..7)
            for (int i = 0; i < 10; i += 2)
            {
                for (int j = 0; j < 7; j += 2)
                {
                    sum += array[i, j];
                }
            }

            return sum;
        }
    }
}