using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] reversed = new int[numbers.Length ];
            for (int i = 0; i < numbers.Length; i++)
            {
                reversed[i] = numbers[numbers.Length - 1 - i];
            }
            foreach (var item in reversed)
            {
                Console.Write(item+" ");
            }
        }
    }
}
