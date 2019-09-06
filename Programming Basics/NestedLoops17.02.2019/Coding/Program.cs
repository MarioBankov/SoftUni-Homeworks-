using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string numberAsString = n + "";

            for (int i = 0; i < numberAsString.Length; i++)
            {
                int lastDigit = int.Parse(numberAsString[numberAsString.Length - 1 - i] + "");
                if (lastDigit==0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int j = 0; j < lastDigit; j++)
                {
                    Console.Write((char)(lastDigit+33));
                }
                Console.WriteLine();
            }
        }
    }
}
