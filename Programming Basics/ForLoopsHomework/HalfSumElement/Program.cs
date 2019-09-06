
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int biggest = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number>biggest)
                {
                    biggest = number;
                }

            }
            int dif =  Math.Abs(sum - biggest);
            if (biggest==dif)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",biggest);
            }
            else
            {
                int diff =  Math.Abs( biggest - dif);  // 10 - (10-12)  10-2 =  8
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",diff);
            }
        }
    }
}
