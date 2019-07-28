using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine().Split();
                string continet = entry[0];
                string country = entry[1];
                string city = entry[2];
                if (dict.ContainsKey(continet)==false)
                {
                    dict.Add(continet, new Dictionary<string, List<string>>());
                }
                if (dict[continet].ContainsKey(country)==false)
                {
                    dict[continet].Add(country, new List<string>());
                }
                dict[continet][country].Add(city);
            }
            foreach (var item in dict)
            {
                Console.WriteLine("{0}:",item.Key);
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine("{0} -> {1}",kvp.Key,string.Join(", ",kvp.Value));
                }
            }
        }
    }
}
