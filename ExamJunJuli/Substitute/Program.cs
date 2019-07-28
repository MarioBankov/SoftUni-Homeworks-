using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourhNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstNumber; i <= 8; i++)
            {
                for (int k = 9; k >= secondNumber; k--)
                {
                    for (int l = thirdNumber; l <= 8; l++)
                    {
                        for (int m = 9; m >= fourhNumber; m--)
                        {
                            if (counter==6)
                            {
                                break;
                            }
                            if (i!=l||k!=m)
                            {
                                if (i%2==0&&k%2!=0&&l%2==0&&m%2!=0)
                                {
                                    Console.WriteLine("{0}{1}-{2}{3}", i, k, l, m);
                                    counter++;
                                }
                                
                            }
                            else if (i % 2 == 0 && k % 2 != 0 && l % 2 == 0 && m % 2 != 0)
                            
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
