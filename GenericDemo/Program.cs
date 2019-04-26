using System;

namespace GenericDemo
{
    public class Calculete<TProduct> where TProduct:Product
    {
        public int Display(TProduct product)
        {
            return product.Price;
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public class GenericList<T> where T :IComparable
    {
        public void Add(T list)
        {

        }
        public T Max(T a,T b)
        {
            return a.CompareTo(b)>0 ? a : b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new GenericList<int>();
            data.Add(1);
            Console.WriteLine(data.Max(100,55));
            
            var x = new Calculete<Product>();
            Console.WriteLine(x.Display(new Product())); ;
            Console.ReadKey();

        }
    }
}
