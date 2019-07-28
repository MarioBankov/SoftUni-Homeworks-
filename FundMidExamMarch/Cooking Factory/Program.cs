using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> best = new List<int>();

            while (true)
            {
                string data = Console.ReadLine();
                if (data == "Bake It!")
                {
                    break;
                }
                
                List<int> current = data.Split('#').Select(int.Parse).ToList();
                if (current.Sum() > best.Sum())
                {
                    best = current;
                }
                else if (current.Sum()==best.Sum())
                {
                    if (current.Average()>best.Average())
                    {
                        best = current;
                    }
                    else if(current.Average()==best.Average())
                    {
                        if (current.Count>best.Count)
                        {
                            best = current;
                        }
                    }
                }
            }

            Console.WriteLine("Best Batch quality: {0}", best.Sum());
            Console.WriteLine(string.Join(" ", best));

        }

    }
}

