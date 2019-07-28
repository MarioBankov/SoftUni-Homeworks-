using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            
            int j = 1;
            foreach (var item in products)
            {
                Console.WriteLine("{0}.{1}",j,item);
                j++;
            }
            
        }
    }
}
