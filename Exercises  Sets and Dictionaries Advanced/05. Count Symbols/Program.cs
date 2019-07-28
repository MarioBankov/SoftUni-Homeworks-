using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<char, int>();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (dict.ContainsKey(text[i])==false)
                {
                    dict.Add(text[i], 0);
                }
                dict[text[i]]++;
            }
            foreach (var item in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine("{0}: {1} time/s",item.Key,item.Value);
            }
        }
    }
}
