using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                string colorr = data[0];
                List<string> items = data[1].Split(",").ToList();
                if (dict.ContainsKey(colorr) == false)
                {
                    dict.Add(colorr, new Dictionary<string, int>());
                }
                for (int j = 0; j < items.Count; j++)
                {
                    if (dict[colorr].ContainsKey(items[j]) == false)
                    {
                        dict[colorr].Add(items[j], 0);
                    }
                    dict[colorr][items[j]]++;
                }

            }

            string[] clothingToFind = Console.ReadLine().Split();
            string color = clothingToFind[0];
            string item1 = clothingToFind[1];
            foreach (var  kvp in dict)
            {
                Console.WriteLine("{0} clothes:",kvp.Key);
                foreach (var item in kvp.Value )
                {
                    if (color == kvp.Key && item1 ==item.Key)
                    {
                        Console.WriteLine("* {0} - {1} (found!)", item.Key, item.Value);
                        continue;
                    }
                    Console.WriteLine("* {0} - {1}",item.Key,item.Value);
                    
                }
            }
        }
    }
}
