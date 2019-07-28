using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool haveEqualSum = false;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int k = array.Length - 1; k > i; k--)
                {
                    rightSum += array[k];
                }
             
                if (leftSum == rightSum)
                {
                     haveEqualSum = true;
                    Console.WriteLine(i);
                }
            }
            if (haveEqualSum==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
