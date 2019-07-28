using System;
using System.Linq;

namespace EvenOddSubstration
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddSum = 0;
            int evenSum = 0;
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                   
                    oddSum += array[i];
                }
                else
                {
                    evenSum += array[i];
                }
            }
            Console.WriteLine(oddSum-evenSum);
        }
    }
}
