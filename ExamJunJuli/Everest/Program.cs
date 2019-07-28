using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string night = Console.ReadLine();
            int climbMetres = int.Parse(Console.ReadLine());

            int counter = 1;
            double climbedMetres = 5364;

            while (night != "END")
            {

                climbedMetres += climbMetres;
                if (night == "Yes")
                {

                    counter++;

                }
                if (climbedMetres > 8848 & counter <= 5)
                {
                    Console.WriteLine($"Goal reached for {counter} days!");
                    break;
                }
                if (counter > 5)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{climbedMetres}");
                    break;
                }
                night = Console.ReadLine();
                climbMetres = int.Parse(Console.ReadLine());

            }

            if (night == "END")
            {
                if (climbedMetres < 8848)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{climbedMetres}");
                }
            }


        }
    }
}