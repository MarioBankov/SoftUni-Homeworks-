using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i]>array[i+1])
                {
                    bool isBig = true;
                    for (int j = i+1; j < array.Length; j++)
                    {
                        if (array[j]>array[i])
                        {
                            isBig = false;
                        }
                    }
                    if (isBig)
                    {
                        Console.Write(array[i]+" ");
                    }
                }
            }
            Console.Write(array[array.Length-1]);
        }
    }
}
