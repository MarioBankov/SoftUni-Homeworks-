using System;

namespace RecrusiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i==0||i==1)
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] += array[i - 1] + array[i - 2];
                }

            }
            Console.WriteLine(array[array.Length-1]);
          
        }
    }
}
