using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                string[] tokens = input.Split();
                if (tokens[0]=="Add")
                {
                    int pasengers = int.Parse(tokens[1]);
                    wagons.Add(pasengers);
                }
                else
                {
                    int pasengers = int.Parse(tokens[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i]+pasengers<=maxCapacity)
                        {
                            wagons[i] += pasengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
