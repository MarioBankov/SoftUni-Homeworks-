using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int counter = 0;
            

            while (pokePower>distance)
            {
                pokePower -= distance;
                counter++;
                if (pokePower==distance)
                {
                    pokePower = pokePower / exhaustion;
                    break;
                }
               
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
