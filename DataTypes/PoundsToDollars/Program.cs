using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int pounds = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:f3}",pounds*1.31);
        }
    }
}
