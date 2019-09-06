using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                sum += numberOfPeople;
                array[i] = numberOfPeople;
            }
            Console.WriteLine(string.Join(" ",array));
            Console.WriteLine(array.Sum());
        }
    }
}
