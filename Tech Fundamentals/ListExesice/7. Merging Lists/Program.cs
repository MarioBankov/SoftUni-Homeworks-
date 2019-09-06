using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int>second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int smallest = Math.Min(first.Count, second.Count);
            for (int i = 0; i < smallest; i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }
            if (first.Count>second.Count)
            {

                for (int i = second.Count; i < first.Count; i++)
                {
                    result.Add(first[i]);
                }
            }
            else
            {
                for (int i = first.Count ; i < second.Count; i++)
                {
                    result.Add(second[i]);
                }

            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
