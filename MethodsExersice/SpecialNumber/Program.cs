using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (SumOfDigits(i) % 8 == 0 && HoldsOneOddDigit(i) == true)
                {
                    Console.Write(i + " ");
                }
            }

        }
        static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static bool HoldsOneOddDigit(int number)
        {
            bool haveOneOdd = false;
            int a = 0;
            int counter = 0;
            while (number > 0)
            {

                a = number % 10;
                number /= 10;
                if (a % 2 == 1)
                {
                    counter++;
                }
                if (counter > 0)
                {
                    haveOneOdd = true;
                }

            }
            return haveOneOdd;
        }
    }
}
