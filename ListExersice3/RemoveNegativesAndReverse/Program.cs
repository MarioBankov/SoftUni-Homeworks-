using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]<0) 
                {
                    numbers.Remove(numbers[i]); 
                    i--;
                }
            }
            for (int i = 0; i < numbers.Count/2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1-i];
                numbers[numbers.Count - 1 - i] = temp;

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
