using System;

namespace Лаб6
{   
    class Program { 
        class Example
        {
            public int x;
            public int y;
            public Example(int x)
            {
                this.x = x;
            }
            public static void Init(Example a)
            {
                Example v = a;
                a.x = 1;
                a.y = 1;
                v.x = 1231;
                v.y = 112;
                Console.WriteLine("a.x = {0}\ta.y = {1} ", a.x, a.y);
                Console.WriteLine("v.x = {0}\tv.y = {1} ", v.x, v.y);

            }
            public static void Sqr(double a, double b)
            {
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                Console.WriteLine("В методе Sqr. a = {0:#.###}\tb = {1:#.###}", a, b);
            }
        } 
        static void Main()
        {
            double a = 5.2, b = 7.3;
            Example.Sqr(a, b);
            Console.WriteLine("a = {0}\tb = {1} ", a,b);
            Example.Sqr(a * 2, b * 2);
            Console.WriteLine("a = {0}\tb = {1} ", a, b);
            Example c = new Example(0);
            Console.WriteLine("x = {0}\ty = {1} ", c.x, c.y);
            Example.Init(c);
            Console.WriteLine("x = {0}\ty = {1} ", c.x, c.y);
        }
    }
}
