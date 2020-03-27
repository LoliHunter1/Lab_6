using System;

namespace Зад4
{
    class Program
    {
        static double Avarge(params int[] arr)
        {
            double avg = 0;
            foreach (int a in arr)
                avg += a;
            return (avg/arr.Length);

        }
        static void Main()
        {
            double B;
            int[] A = { 1,2,3,4 };
            Console.WriteLine("Среднее значение элементов массива = {0} ",Avarge(A));
            short z = 1, e = 12;
            byte v = 107;
            Console.WriteLine(Avarge(z, e, v));
            Console.WriteLine(Avarge());
        }
    }
}
