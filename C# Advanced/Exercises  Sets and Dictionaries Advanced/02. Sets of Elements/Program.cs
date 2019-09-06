using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new HashSet<int>();
            var second = new HashSet<int>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers[0]; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < numbers[1]; i++)
            {
               second.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var item in first)
            {
                if (second.Contains(item))
                {
                    Console.Write(item+" ");
                }
            }
        }
    }
}
