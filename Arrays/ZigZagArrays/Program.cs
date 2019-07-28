using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
               int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i%2==0)
                {
                 array1[i] = elements[0];
                 array2[i] = elements[1];
                }
                else
                {
                    array1[i] = elements[1];
                    array2[i] = elements[0];
                }
                
            }
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
        }
    }
}
