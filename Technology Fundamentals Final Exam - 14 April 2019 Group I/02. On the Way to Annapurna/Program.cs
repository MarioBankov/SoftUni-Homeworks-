using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="END")
                {
                    break;
                }
                string[] info = data.Split("->");
                string command = info.First();
                if (command=="Add")
                {
                    string shop = info[1];
                    List<string> items = info[2].Split(",").ToList();
                    if (dict.ContainsKey(shop)==false)
                    {
                        dict.Add(shop, new List<string>());
                    }
                    for (int i = 0; i < items.Count; i++)
                    {
                            dict[shop].Add(items[i]);
                    }
                }
                else if (command=="Remove")
                {
                    string shop = info[1];
                    if (dict.ContainsKey(shop))
                    {
                        dict.Remove(shop);
                    }
                }
            }
            Console.WriteLine("Stores list:");
            foreach (var item in dict.OrderByDescending(x=>x.Value.Count()).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine("<<{0}>>",item1);
                }
            }
        }
    }
}
