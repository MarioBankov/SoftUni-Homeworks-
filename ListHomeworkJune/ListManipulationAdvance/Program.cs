using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            while (true)
            {
                string data = Console.ReadLine();
                if (data=="end")
                {
                    break;
                }
                string[] commands = data.Split();
                string command = commands[0];
                if ( command=="Contains")
                {
                    int number = int.Parse(commands[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command=="PrintEven")
                {
                    Console.WriteLine(string.Join(" ",numbers.Where(x=>x%2==0)));
                }
                else if (command=="PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1)));
                }
                else if (command=="GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command=="Filter")
                {
                    
                    string opr = commands[1];
                    int number = int.Parse(commands[2]);
                    switch (opr)
                    {
                        case "<": Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                            break;
                        case ">":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                            break;
                        case "<=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                            break;
                        case ">=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                            break;
                        case "=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x == number)));
                            break;
                        default:
                            break;
                    }
                   
                }

            }
            

        }

      
    }
}
