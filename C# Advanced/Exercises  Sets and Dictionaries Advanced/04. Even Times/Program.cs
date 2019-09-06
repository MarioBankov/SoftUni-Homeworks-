using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(number)==false)
                {
                    dict.Add(number, 0);
                }
                dict[number]++;
            }
            foreach (var item in dict)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
