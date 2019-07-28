using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberToString = number + "";
            int sum = 0;
            for (int i = 0; i <numberToString.Length; i++)
            {
                sum += int.Parse(numberToString[i]+"");
            }
            Console.WriteLine(sum);
        }
    }
}
