using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine("Arrays are not identical. Found difference at {0} index",i);
                    return;
                }
            }
            Console.WriteLine("Arrays are identical. Sum: {0}",arrayTwo.Sum());
        }
    }
}
