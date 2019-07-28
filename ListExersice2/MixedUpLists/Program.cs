using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mixed = new List<int>();

            int min = Math.Min(first.Count, second.Count);
            for (int i = 0; i < min; i++)
            {
                mixed.Add(first[i]);
                mixed.Add(second[second.Count - i - 1]);

            }
            if (first.Count > second.Count)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < min * 2; i++)
                {
                    int biggest = Math.Max(first[first.Count - 1],first[first.Count - 2]);
                    int smallest = Math.Min(first[first.Count - 1], first[first.Count - 2]);
                    if (mixed[i] < biggest && mixed[i] > smallest)
                    {
                        result.Add(mixed[i]);
                    }

                }
                result.Sort();
                Console.WriteLine(string.Join(" ", result));
            }
            else if (second.Count > first.Count)
            {
              
                List<int> result = new List<int>();
                for (int i = 0; i < mixed.Count; i++)
                {
                    int biggest = Math.Max(second[0], second[1]);
                    int smallest = Math.Min(second[0], second[1]);
                    if (mixed[i] < biggest && mixed[i] > smallest)
                    {
                        result.Add(mixed[i]);
                    }

                }
                result.Sort();
                Console.WriteLine(string.Join(" ", result));
            }



        }
    }
}
