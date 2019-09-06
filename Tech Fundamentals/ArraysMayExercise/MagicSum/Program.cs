using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, 
            //which prints all unique pairs in an array of integers whose sum is equal to a given number.

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    int nextNumber = array[j];
                    if (currentNumber+nextNumber==magicSum)
                    {
                        Console.WriteLine("{0} {1}",currentNumber,nextNumber);
                    }

                }
            }

        }
    }
}
