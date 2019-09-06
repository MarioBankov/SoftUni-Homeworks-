using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int lev = int.Parse(Console.ReadLine());
            int dva = int.Parse(Console.ReadLine());
            int pet = int.Parse(Console.ReadLine());

            int sum = int.Parse(Console.ReadLine());

            for (int first = 0; first <= lev; first++) 
            {
                for (int second = 0; second <= dva; second++) 
                {
                    for (int thirt = 0; thirt <= pet; thirt++) 
                    {
                        int one = first * 1;
                        int two = second * 2;
                        int three = thirt *5;
                        if (one+two+three==sum)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.",first,second,thirt,sum);
                        }
                    }
                }
            }
        }
    }
}
