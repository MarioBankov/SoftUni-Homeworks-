using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeTheBitAtPositionP
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            string NumberAsBits = Convert.ToString(number, 2);
            Console.WriteLine(NumberAsBits.PadLeft(8,'0'));
            int mask = 1;
            int result = ((mask << p) & number) >> p;
            Console.WriteLine(result);

        }
    }
}
