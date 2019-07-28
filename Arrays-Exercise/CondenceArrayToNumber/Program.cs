using System;
using System.Linq;

namespace CondenceArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (array.Length > 1)
            {


                int[] array2 = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array2[i] = array[i] + array[i + 1];
                }
                array = array2;
            }
            
            Console.WriteLine(array[0]);
        }
    }
}
