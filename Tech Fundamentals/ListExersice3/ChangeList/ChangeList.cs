using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Delete")
                {
                    int number = int.Parse(tokens[1]);
                    numbers = numbers.Where(x => x != number).ToList();
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    int number = int.Parse(tokens[1]);
                    numbers.Insert(index, number);
                }
                
            }
            Console.WriteLine(string.Join(" ",numbers));
        }

    }
}
