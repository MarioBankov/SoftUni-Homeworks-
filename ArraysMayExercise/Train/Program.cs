using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //number of wagons
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];

            for (int i = 0; i < n; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            //Print the train 
            Console.WriteLine(string.Join(" ",train));
            //print sum of ppl in train 
            Console.WriteLine(train.Sum());
        }
    }
}
