using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int couter = 0;
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                
                string command = Console.ReadLine();
                if (command == "end")
                {
                    if (couter> 0)
                    {
                        Console.WriteLine(string.Join(" ",numbers));
                    }
                  
                    break;
                }
                string[] tokens = command.Split();
                if (tokens[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(tokens[1])) == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    var evenNumber = numbers.Where(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumber));
                }
                else if (command == "PrintOdd")
                {
                    var oddNumber = numbers.Where(x => x % 2 == 1);
                    Console.WriteLine(string.Join(" ", oddNumber));
                }
                else if (command == "GetSum")
                {
                    int total = numbers.Sum();
                    Console.WriteLine(total);
                }
                else if (tokens[0] == "Filter")
                {
                    couter++;
                    int a = int.Parse(tokens[2]);

                    if (tokens[1] == '<' + "")
                    {
                        var result = numbers.Where(x => x < a);
                        Console.WriteLine(string.Join(" ", result));
                    }
                    else if (tokens[1] == '>' + "")
                    {
                        var result = numbers.Where(x => x > a);
                        Console.WriteLine(string.Join(" ", result));
                    }
                    else if (tokens[1] == ">=")
                    {
                        var result = numbers.Where(x => x >= a);
                        Console.WriteLine(string.Join(" ", result));
                    }
                    else if (tokens[1] == "<=")
                    {
                        var result = numbers.Where(x => x <= a);
                        Console.WriteLine(string.Join(" ", result));
                    }

                }
               




            }
        }
    }
}
