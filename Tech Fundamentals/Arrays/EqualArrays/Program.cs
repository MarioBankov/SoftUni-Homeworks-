using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool areEqual = false;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i]!=array2[i])
                {
                    Console.WriteLine("Arrays are not identical. Found difference at {0} index",i);
                    break;
                }
                else
                {
                    areEqual = true;
                }
                if (areEqual == true&& i ==array.Length-1)
                {
                    Console.WriteLine("Arrays are identical. Sum: {0}",sum);
                }
            }
        }
    }
}
