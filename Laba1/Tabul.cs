using System;

namespace Laba1
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private double f1(double x)
        {
            double denom = Math.Pow(x, 3) + x + 1;
            if (Math.Abs(denom) < 0.00001) return double.NaN;
            return Math.Cos(Math.Pow(x, 3) - 4 * x + 4) / denom;
        }

        private double f2(double x)
        {
            double denom = Math.Sqrt(2 * Math.Pow(x, 2) + Math.Pow(x, 4) + 1);
            if (Math.Abs(denom) < 0.00001) return double.NaN;
            return Math.Pow(Math.Sin(x + 2), 2) / denom;
        }

        private double f3(double x)
        {
            double denom = Math.Pow(Math.Cos(x + 1), 2);
            if (Math.Abs(denom) < 0.00001) return double.NaN;
            return Math.Sqrt(Math.Abs(Math.Pow(x, 3) * Math.Sin(Math.Pow(x, 3)))) / denom;
        }

        public void tab(double xn, double xk, double h, double a)
        {
            n = 0;
            double x = xn;

            // Класичний цикл табулювання з урахуванням похибки double (+ h/2)
            while (x <= xk + h / 2.0 && n < 1000)
            {
                double y = (x <= 0) ? f1(x) : (x <= a) ? f2(x) : f3(x);

                xy[n, 0] = x;
                xy[n, 1] = y;
                n++;

                x += h;
            }
        }
    }
}