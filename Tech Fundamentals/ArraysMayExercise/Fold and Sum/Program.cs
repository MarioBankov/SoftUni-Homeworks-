using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int topElementsLenght = array.Length / 4;   //3
            int[] topElements = new int[topElementsLenght * 2];  //6

            for (int i = 0; i < topElementsLenght; i++)  //3
            {
                topElements[i] = array[(topElementsLenght)-i-1];
            }
            for (int i = 0; i < topElementsLenght; i++)
            {
                topElements[topElementsLenght+i] = array[array.Length-1-i];
            }
            

            for (int i = 0; i < topElements.Length; i++)
            {
                Console.Write(topElements[i] + array[topElementsLenght + i]+" "); 
            }

        }
    }
}
