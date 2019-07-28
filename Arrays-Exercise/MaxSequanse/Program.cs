using System;
using System.Linq;

namespace MaxSequanse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = 0;
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i]==array[i+1])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count>maxCount)
                {
                    number = array[i];
                    maxCount = count;
                }
            }
            for (int i = 0; i < maxCount+1; i++)
            {
                Console.Write(number+" ");
            }
        }
    }
}
