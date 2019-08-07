using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> vat = n => double.Parse(n) + (double.Parse(n) * 0.20);
            var a =Console.ReadLine().Split(",").Select(vat);
            foreach (var item in a)
            {
                Console.WriteLine("{0:f2}",item);
            }
        }
    }
}
