using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int shortestLenght = Math.Min(first.Count, second.Count);
            for (int i = 0; i < shortestLenght; i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }

            if (first.Count>second.Count)
            {
                for (int i = shortestLenght; i < first.Count; i++)
                {
                    result.Add(first[i]);
                }
            }
            else
            {
                for (int i = shortestLenght; i < second.Count; i++)
                {
                    result.Add(second[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
