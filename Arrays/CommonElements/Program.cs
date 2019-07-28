using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();
            string[] result = new string[array.Length];

            for (int i = 0; i < array2.Length; i++) 
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array2[i]==array[j])
                    {
                        result[i] = array2[i];
                    }
                }
                
               
            }
            for (int a = 0; a < result.Length; a++)
            {
                Console.Write(result[a] + " ");
            }
        }
    }
}
