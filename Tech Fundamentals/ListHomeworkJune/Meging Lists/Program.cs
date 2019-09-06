using System;
using System.Collections.Generic;
using System.Linq;

namespace Meging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split().Select(int.Parse).ToList();
            var second = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();
            int count = Math.Min(first.Count, second.Count);
            for (int i = 0; i < count; i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }
            if (first.Count>second.Count)
            {
                int start = second.Count;
                for (int i = start  ; i < first.Count; i++)
                {
                    result.Add(first[i]);
                }
            }
            else
            {
                int start = first.Count;
                for (int i = start; i < second.Count; i++)
                {
                    result.Add(second[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
