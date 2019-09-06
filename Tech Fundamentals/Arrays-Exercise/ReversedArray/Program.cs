using System;

namespace ReversedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                array[array.Length-1-i] = number;
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
