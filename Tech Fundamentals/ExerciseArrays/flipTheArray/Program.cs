using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flipTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            
            int[] array2 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                array2[array2.Length - 1 - i] = array[i];
            }
            foreach (var item in array)
            {
                Console.Write(item + "  ");
                
            }
            Console.WriteLine();
            foreach (var number in array2)
            {
                Console.Write(number + "  ");
            }
        }
    }
}
