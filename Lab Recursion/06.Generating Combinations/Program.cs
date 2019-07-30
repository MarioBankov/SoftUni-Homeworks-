using System;
using System.Linq;

namespace _06.Generating_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] arrK = new int[k];
            FindKpears(arr, arrK, 0 ,0);
           
        }

        private static void FindKpears(int[] set, int[] vector, int index , int border )
        {
            if (index==vector.Length)
            {
                Console.WriteLine(string.Join(" ",vector)); 
            }
            else
            {
                for (int i = border ; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    FindKpears(set, vector, index + 1, i+1);
                }

            }


        }
    }
}
