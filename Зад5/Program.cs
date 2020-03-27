using System;

namespace Зад5
{
    class Program
    {
        static double Avarge(ref int a1,params int[] arr)
        {
            a1++;
            double avg = 0;
            foreach (int a in arr)
                avg += a;
            return (avg / arr.Length);

        }

        static void Strochka(params char[] a)
        {
            int i = 192;
            for (int j = 0; j < a.Length; j ++)
            {
                a[j] = Convert.ToChar(i);
                i++;
            }
                
        }

        static double Avarge1(int[] arr)
        {
            double avg = 0;
            foreach (int a in arr)
                avg += a;
            return (avg / arr.Length);
        }
        static void WhatsType(Object a)
        {   
            Console.WriteLine(a.GetType());
        }

        static void Main()
        {
            int[] a = {1,2,3,4,5,6};
            int b = 1, c = 2, d = 3, e = 4, f = 5, g = 6;
            Console.WriteLine(Avarge(ref b, c, d, e, f, g));
            Console.WriteLine(Avarge(ref b, a));
            Console.WriteLine(b);
            //Происходит ошибка Console.WriteLine(Avarge1(b, c, d, e, f, g));
            Console.WriteLine(Avarge1(a));
            char[] as1 = { 'П','р','о','с','т','о',' ','с','т','р','о','ч','к','а' };
            Strochka(as1);
            WhatsType(a);
        }
    }
}
