using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int number = 0;
            int currentBest = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                
                if (array[i] ==array[i+1])
                {
                    currentBest++;
                   
                }
                else
                {
                    currentBest = 0;
                }
                if (currentBest>count)
                {
                    count = currentBest;
                    number = array[i];
                }
            }
            for (int i = 0; i < count+1; i++)
            {
                Console.Write(number+" ");
            }
        }
    }
}
