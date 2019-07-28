
namespace ListManupulationAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;

                }
                string[] tokens = input.Split();

                string command = tokens[0];
                if (command == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    if (sequence.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command =="PrintEven")
                {
                    Console.WriteLine(string.Join(" ",sequence.Where(x=>x%2==0)));
                }
                else if (command=="PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", sequence.Where(x => x % 2 == 1)));
                }
                else if (command=="GetSum")
                {
                    Console.WriteLine(sequence.Sum());
                }
                else if (command=="Filter")
                {
                    string condition = tokens[1];
                    int number =int.Parse( tokens[2]);
                  var filtered= Filter(sequence, condition, number);
                    Console.WriteLine(string.Join(" ",filtered));
                }
            
            }
        }

        private static List<int> Filter(List<int> sequence, string condition, int number)
        {
            
            if (condition==">")
            {
               return sequence.Where(x => x > number).ToList();
            }
            else if (condition=="<")
            {
              return sequence.Where(x => x < number).ToList();
            }
            else if (condition=="<=")
            {
               return sequence.Where(x => x <= number).ToList();
            }
            else if (condition==">=")
            {
               return  sequence.Where(x => x >= number).ToList();
            }

            return sequence;
        }
    }
}
