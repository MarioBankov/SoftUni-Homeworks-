using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            string result = Convert.ToString(number, 2);
            Console.WriteLine(result.PadLeft(8, '0'));
            int mask1 = (1 << p);
            int mask = ~mask1;
            string result1 = Convert.ToString(mask, 2);
            Console.WriteLine(result1);
            int final = mask & number;
            Console.WriteLine(final);
        }
    }
}
