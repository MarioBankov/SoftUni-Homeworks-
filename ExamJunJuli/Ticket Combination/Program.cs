using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int ch = 66; ch <= 76; ch+=2)
            {

                for (char ch1 = 'f'; ch1 >= 'a'; ch1--)
                {

                    for (char ch2 = 'A'; ch2 <= 'C'; ch2++)
                    {

                        for (int one = 1; one <= 10; one++)
                        {

                            for (int k = 10; k >= 1; k--)
                            {
                                counter++;
                                if (counter==number)
                                {
                                    Console.WriteLine("Ticket combination: {0}{1}{2}{3}{4}", (char)ch, ch1, ch2, one, k);
                                    Console.WriteLine("Prize: {0} lv.", ch + (int)ch1 + (int)ch2 + one + k);
                                    return;
                                }

                                


                            }
                        }

                    }
                }
            }
        }
    }
}
