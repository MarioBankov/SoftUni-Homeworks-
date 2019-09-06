using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int first = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int second = numbers[j];
                    if (first+second==n)
                    {
                        Console.WriteLine("{0} {1}",first,second);
                    }
                }
            }
        }
    }
}
