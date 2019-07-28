using System;
using System.Collections.Generic;
using System.Linq;

namespace HauseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<String> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length==3)
                {
                    if (names.Contains(input[0])==false)
                    {
                        names.Add(input[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is already in the list!",input[0]);
                    }
                }
                else
                {
                    if (names.Contains(input[0])==false)
                    {
                        Console.WriteLine("{0} is not in the list!",input[0]);
                    }
                    else
                    {
                        names.Remove(input[0]);
                    }
                }
 
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
