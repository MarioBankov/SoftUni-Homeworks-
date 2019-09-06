using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string type = Console.ReadLine();
            List<int> numbers = new List<int>();
            int start = bounds[0];
            int end = bounds[1];
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }
            Predicate<int> isEven = x => x % 2 ==0;
            Predicate<int> isOdd = x => x % 2 != 0;
            if (type=="odd")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x=>x%2!=0).ToList())); 
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => isEven(x)).ToList()));
            }
            
        }
    }
}
