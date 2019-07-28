using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int first = numbers[i];
                for (int j = i + 1; j < numbers.Length ; j++)
                {
                    int next = numbers[j];
                    if (first<next)
                    {
                        break;
                    }
                    else if (j == numbers.Length-1)
                    {
                        Console.Write(first+" ");
                    }
                }
               
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
