using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManutulationBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="end")
                {
                    break;
                }
                string[] commands  = data.Split();
                string command = commands[0];

                if (command=="Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                }
                else if (command=="Remove")
                {
                    numbers.Remove(int.Parse(commands[1]));
                }
                else if (command=="RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                }
                else if (command=="Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
            }
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
