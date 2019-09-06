using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < n; i++)

            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                }
                else if (number < 400)
                {
                    p2++;
                }
                else if (number < 600)
                {
                    p3++;
                }
                else if (number < 800)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }
            }
            double p1p = (p1 * 1.00 / n) * 100;
            double p2p = (p2 * 1.00 / n) * 100;
            double p3p = (p3 * 1.00 / n) * 100;
            double p4p = (p4 * 1.00 / n) * 100;
            double p5p = (p5 * 1.00 / n) * 100;

            Console.WriteLine($"{p1p:F2}%");
            Console.WriteLine($"{p2p:F2}%");
            Console.WriteLine($"{p3p:F2}%");
            Console.WriteLine($"{p4p:F2}%");
            Console.WriteLine($"{p5p:F2}%");
        }
    }
}
