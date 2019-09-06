using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var guest = new HashSet<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower()=="party")
                {
                    break;
                }
                guest.Add(command);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "end")
                {
                    break;
                }
                guest.Remove(command);
            }
            Console.WriteLine(guest.Count);
            foreach (var item in guest)
            {
                Console.WriteLine(item);
            }
        }
    }
}
