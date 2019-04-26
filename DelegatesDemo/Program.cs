using System;

namespace DelegatesDemo
{
   
    class Program
    {
        public delegate void mydelegate(string x);
           
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static string Display(string s)
        {
            return "output : " + s;
        }
        static void Main(string[] args)
        {
            Action<string> action = new Action<string>(Print);
            action("sss");

            Func<string, string> f = new Func<string, string>(Display);
            Console.WriteLine(f("Akshay")); ;
            //mydelegate v = Print;
            //v += Display;
            //v("asd");
            //v("a");
            Console.ReadKey();
            
        }
    }
}
