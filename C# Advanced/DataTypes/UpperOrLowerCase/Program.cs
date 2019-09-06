using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperOrLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol>=97)
            {
                Console.WriteLine("lower-case");
              
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
