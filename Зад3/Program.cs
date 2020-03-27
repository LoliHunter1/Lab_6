using System;

namespace Зад3
{
    class Program
    {
        static void Info(double a, out int sign, out bool isInteger, out double abs, out double sqr)
        {
            sign = Math.Sign(a);
            isInteger = a % 1 == 0 ? true : false;
            abs = Math.Abs(a);
            sqr = a * a;
        }
        static void Main()
        {
            int a;
            bool b;
            double c, d, A = 42, B = -12.67;
            Info(A, out a, out b, out c, out d);
            Console.WriteLine(" В числе {0}\tЗнак равен {1}, Целое ли число = {2}, Модуль = {3}, Квадрат = {4}", A, a, b, c, d);
            Info(B, out a, out b, out c, out d);
            Console.WriteLine(" В числе {0}\tЗнак равен {1}, Целое ли число = {2}, Модуль = {3}, Квадрат = {4}", B, a, b, c, d);
        }
    }
}
