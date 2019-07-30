using System;
using System.Linq;

namespace _1._Recursive_Array_Sum
{
    class Program
    {
        public static int GetSum(int[]arr,int index)
        {
           
            if (index==arr.Length)
            {
                return 0;
            }
            var currentSum= arr[index] + GetSum(arr, index + 1);

            return currentSum;
          
        }
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = GetSum(array, 0);
            Console.WriteLine(sum);
        }
    }
}
