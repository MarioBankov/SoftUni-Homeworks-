using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i =0; i < array.Length-1; i++)
            {
                if (array[i]>array[i+1])
                {
                    Console.Write(array[i]+" ");
                }
               
            }
            Console.WriteLine(array[array.Length - 1]);
        }
    }
}
