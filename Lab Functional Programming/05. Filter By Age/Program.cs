using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                string[] data = Console.ReadLine().Split(", ");
                if (!dict.ContainsKey(data[0]))
                {
                    dict.Add(data[0], int.Parse(data[1]));
                }
            }
            string older = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] nameAge = Console.ReadLine().Split();
            Func<KeyValuePair<string, int>, bool> sort1 = x => x.Value >= age;
            Func<KeyValuePair<string, int>, bool> sort2 = x => x.Value <= age;
            
            if (older=="older")
            {
                dict = dict.Where(sort1).ToDictionary(x => x.Key, y => y.Value);
            }
            else
            {
                dict = dict.Where(sort2).ToDictionary(x => x.Key, y => y.Value);
            }
            if (nameAge.Count()==2)
            {
                foreach (var item in dict)
                {
                    Console.WriteLine("{0} - {1}",item.Key,item.Value);
                }
            }
            else
            {
                foreach (var item in dict)
                {
                    Console.WriteLine("{0}", item.Key);
                }
            }
        }
    }
}
