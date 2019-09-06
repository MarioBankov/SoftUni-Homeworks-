using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secetdoor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int first = 1; first <= a; first++)
            {
                for (int second = 1; second <= b; second++)
                {
                    for (int thirh = 1; thirh <= c; thirh++)
                    {
                        if (second == 3 || second == 5 || second == 7||second==2)
                        {
                            if ((first % 2 == 0 && thirh % 2 == 0))
                            {

                                Console.WriteLine("{0} {1} {2}", first, second, thirh);
                            }
                        }

                    }
                }
            }
        }
    }
}
