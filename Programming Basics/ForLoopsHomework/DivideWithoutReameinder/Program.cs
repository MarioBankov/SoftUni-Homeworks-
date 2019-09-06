using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutReameinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number%2==0)
                {
                    p1++;
                }
                if (number%3==0)
                {
                    p2++;
                }
                if (number % 4==0)
                {
                    p3++;
                }

            }
            double p1p = (p1 * 1.00 / n) * 100;
            double p2p = (p2 * 1.00 / n) * 100;
            double p3p = (p3 * 1.00 / n) * 100;

            Console.WriteLine($"{p1p:F2}%");
            Console.WriteLine($"{p2p:F2}%");
            Console.WriteLine($"{p3p:F2}%");
        }
    }
}
