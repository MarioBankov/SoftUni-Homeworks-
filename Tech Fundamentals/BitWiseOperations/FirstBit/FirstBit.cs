using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary.PadLeft(8, '0'));
            int mask = 1;
            string mask1 = Convert.ToString(mask, 2);
            Console.WriteLine(mask1.PadLeft(8));
            int mask2 = mask << 1;
            string maskk2 = Convert.ToString(mask2, 2);
            Console.WriteLine(maskk2.PadLeft(8,'0'));

            int result = (mask2 & number)>>1;
            Console.WriteLine(result);


        }
    }
}
