using System.Linq;
using System.Web;
using System;





namespace Facturiel
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           ulong facturiel = 1;

            for (int i = 2; i <= number; i++)
            {
                facturiel =facturiel*(ulong)i;
            }
            Console.WriteLine(facturiel);
        }
    }
}
