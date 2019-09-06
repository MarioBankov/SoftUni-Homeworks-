using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string[] entry = Console.ReadLine().Split(", ") ;
                if (entry.First()== "Revision")
                {
                    break;
                }
                string shop = entry[0];
                string product = entry[1];
                double price = double.Parse(entry[2]);
                if (dict.ContainsKey(shop)==false)
                {
                    dict.Add(shop, new Dictionary<string,double>());
                }
                if (dict[shop].ContainsKey(product)==false)
                {
                    dict[shop].Add(product, price);
                }
            }
            foreach (var item in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine("{0}->",item.Key);
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine("Product: {0}, Price: {1}",kvp.Key,kvp.Value);
                }
            }
        }
    }
}
