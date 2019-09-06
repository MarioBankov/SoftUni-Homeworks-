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

            string numberToString = number + "";
            int firstDigit = int.Parse(numberToString[0] + "");
            int secondDigit = int.Parse(numberToString[1] + "");
            int thirthDigit = int.Parse(numberToString[2] + "");
            int row = firstDigit + secondDigit;
            int col = firstDigit + thirthDigit;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firstDigit;
                        Console.Write(number + " ");
                    }
                    else if (number % 3 == 0)
                    {
                        number -= secondDigit;
                        Console.Write(number + " ");
                    }
                    else 

                    {

                        number += thirthDigit;
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }

}







