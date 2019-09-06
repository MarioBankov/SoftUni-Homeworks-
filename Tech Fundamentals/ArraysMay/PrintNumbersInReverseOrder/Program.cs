using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int[] reverse = new int[numbers.Length];
            for (int i = 0; i < count; i++)
            {
                reverse[count - i - 1] = numbers[i];
            }
            Console.WriteLine(string.Join(" ",reverse));
        }
    }
}
