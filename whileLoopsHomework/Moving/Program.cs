using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int freeSpace = a * b * c;
            int diff = 0;
            int sum = 0;

            while (sum <= freeSpace)
            {
                string comand = Console.ReadLine();
                if (comand == "Done")
                {
                    break;
                }
                else
                {
                    int cartoons = int.Parse(comand);
                    sum += cartoons;
                }

            }
            if (sum>=freeSpace)
            {
                diff = sum - freeSpace;

                Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
            }
            else
            {
                diff = sum - freeSpace;
                Console.WriteLine($"{Math.Abs( diff)} Cubic meters left.");
            }
        }
    }
}
