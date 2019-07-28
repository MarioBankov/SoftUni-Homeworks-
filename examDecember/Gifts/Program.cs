using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int kids = 0;
            int elders = 0;
            while (true)
            {
                string imput = Console.ReadLine();
                if (imput =="Christmas")
                {
                    break;
                }
                int years = int.Parse(imput);
                if (years<=16)
                {
                    kids++;
                }
                else
                {
                    elders++;
                }

            }
            Console.WriteLine("Number of adults: {0}",elders);
            Console.WriteLine("Number of kids: {0}",kids);
            Console.WriteLine("Money for toys: {0}",kids*5);
            Console.WriteLine("Money for sweaters: {0}",elders*15);
        }
    }
}
