using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int wamen = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());



            for (int i = 1; i <= men; i++)
            {
                for (int k = 1; k <= wamen; k++)
                {
                    if (tables > 0)
                    {
                        Console.Write("({0} <-> {1}) ", i, k);
                    }
                    tables--;



                }
            }

        }
    }
}
