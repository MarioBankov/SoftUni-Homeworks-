using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            double bits = double.Parse(Console.ReadLine());
            double jana = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double bitsToLeva = bits * 1168;

            double janaToLeva = (jana * 0.15) * 1.76;

            double toEuro = (bitsToLeva + janaToLeva) / 1.95;
            double comms = commision / 100;
            
            double withcomm = toEuro - (toEuro * comms);

            Console.WriteLine("{0:f2}",withcomm);
        }
    }
}
