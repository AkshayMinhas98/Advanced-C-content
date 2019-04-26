using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new HttpCookie();
            data["hy"] = "a";

            Console.WriteLine(data["hy"]);
            Console.ReadKey();
        }
    }
}
