using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
           
        }
        public static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive", number);
            }
            else if (number<0)
            {
                Console.WriteLine("The number {0} is negative", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero", number);
            }
        }
    }

}
