using System;

namespace Laba1
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        // Початкові функції з Варіанту 4 
        private double f1(double x) => Math.Cos(Math.Pow(x, 3) - 4 * x + 4) / (Math.Pow(x, 3) + x + 1);
        private double f2(double x) => Math.Pow(Math.Sin(x + 2), 2) / Math.Sqrt(2 * Math.Pow(x, 2) + Math.Pow(x, 4) + 1);
        private double f3(double x) => Math.Sqrt(Math.Abs(Math.Pow(x, 3) * Math.Sin(Math.Pow(x, 3)))) / Math.Pow(Math.Cos(x + 1), 2);

        public void tab(double xn, double xk, double h, double a)
        {
            n = 0;
            for (double x = xn; x <= xk + 0.00001; x += h)
            {
                double y = (x <= 0) ? f1(x) : (x <= a) ? f2(x) : f3(x);
                xy[n, 0] = x;
                xy[n, 1] = y;
                n++;
            }
        }
    }
}