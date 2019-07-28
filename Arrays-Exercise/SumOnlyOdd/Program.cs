using System;
using System.Linq;

namespace SumOnlyOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
