using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
           
            bool isTrue = false;
            for (int i = 1; i <= number; i++)
{
                int sumOfDigits = 0;
                int num = i;
                while (i > 0)
{
                    sumOfDigits += i % 10;
                    i = i / 10;
                }
                isTrue = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($" {num}->{isTrue}");
               
                i = num;
            }
        }
    }
}
