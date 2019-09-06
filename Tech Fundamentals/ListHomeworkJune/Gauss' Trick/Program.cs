using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = numbers.Count / 2;
            for (int i = 0; i < count; i++)
            {
                numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
