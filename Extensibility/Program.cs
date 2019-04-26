using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new Demo(new ConsoleLog());
            demo.Display();
            Console.ReadKey();
        }
    }
}
