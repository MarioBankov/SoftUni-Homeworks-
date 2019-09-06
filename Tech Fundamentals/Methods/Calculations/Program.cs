using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            calculation(command, firstNumber, secondNumber);

        }
        static void calculation(string command, int first, int second)
        {
            if (command == "add")
            {
                Console.WriteLine(first + second);
            }
            else if (command == "multyply")
            {
                Console.WriteLine(first * second);
            }
            else if (command == "subtrack")
            {
                Console.WriteLine(first - second);
            }
            else if (command == "divide")
            {
                Console.WriteLine(first / second);
            }
        }

    }
}
