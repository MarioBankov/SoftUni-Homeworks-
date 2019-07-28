using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    numbers[i] = numbers[i] * 2;
                    numbers.Remove(numbers[i + 1]);
                    i--;
                }

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
