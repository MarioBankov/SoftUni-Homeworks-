using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] array2 = new int[array.Length];
            for (int j = 0; j < n; j++) 
            {
                int lastElement = array[0];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array2[i] = array[i + 1];
                }
                array2[array.Length - 1] = lastElement;
                array = array2;

            }
            Console.WriteLine(string.Join(" ",array ));
        }
    }
}
