using System;

namespace LambdaExpressionDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Func<int, int> f = new Func<int, int>(Square);
            //Console.WriteLine(f(5));

            Func<int, int> d = x=>x * x;
            Console.WriteLine(d(10));
            Console.ReadKey();
        }
        //public static int Square(int a)
        //{
        //    return a * a;
        //}
    }
}
