using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int a = 0;
            int b = 0;
            if (first.Count>second.Count)
            {
                a = first[first.Count - 1];
                b = first[first.Count - 2];
            }
            else
            {
                a = second[0];
                b = second[1];
            }
            int count = Math.Min(first.Count, second.Count);
            for (int i = 0; i < count; i++)
            {
                result.Add(first[i]);
                result.Add(second[second.Count - 1 - i]);
            }
            int bigest = Math.Max(a, b);
            int smallest = Math.Min(a, b);
            result.Sort();
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i]<bigest&&result[i]>smallest)
                {
                    Console.Write(result[i]+" ");
                }
            }
            
        
            
        }
    }
}
