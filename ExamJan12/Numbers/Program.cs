using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int thirthDigit = number % 10;
            int secondDigit = ((number - thirthDigit) / 10) % 10;
            int firstDigit = (((number - thirthDigit) / 10) - secondDigit) / 10;

            int row = firstDigit + secondDigit;
            int col = firstDigit + thirthDigit;
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < col; k++)
                {
                    if (number%5==0)
                    {
                        number = number - firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number = number - secondDigit;
                    }
                    else
                    {
                        number=number + thirthDigit;
                    }
                    Console.Write(number+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
