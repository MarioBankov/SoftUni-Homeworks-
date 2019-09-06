using System;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] first = new string[n];
            string[] second = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                string firstNumber = numbers[0];
                string secondNumber = numbers[1];
                if (i % 2 != 0)
                {
                    first[i] = firstNumber;
                    second[i] = secondNumber;
                }
                else
                {
                    second[i] = firstNumber;
                    first[i] = secondNumber;
                }
            }
            Console.WriteLine(string.Join(" ",second));
            Console.WriteLine(string.Join(" ",first));
        }
    }
}
