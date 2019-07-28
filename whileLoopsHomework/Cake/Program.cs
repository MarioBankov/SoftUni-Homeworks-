using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {

            int widht = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int peaces = widht * length;
            int sum = 0;
            int peacesLeft = 0;

            while (peaces>=sum)
            {
                string command = Console.ReadLine();
                if (command!="STOP")
                {
                    int takenPeaces = int.Parse(command);
                    sum += takenPeaces;
                }
                else
                {
                    
                    break;

                }
            }
            if (peaces>=sum)
            {
                peacesLeft = peaces - sum;
                Console.WriteLine($"{peacesLeft} pieces are left.");
            }
            else
            {
                int peacesNeeded = sum - peaces;
                Console.WriteLine($"No more cake left! You need {peacesNeeded} pieces more.");
            }

        }
    }
}
