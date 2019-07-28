using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int leftSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum -=array[i];
                if (sum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    leftSum += array[i];
                }
            }

        }
    }
}
