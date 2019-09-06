using System;
using System.Collections.Generic;
using System.Linq;


namespace AutoRepear
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); ;
            Queue<string> queue = new Queue<string>(cars);
            Stack<string> stack = new Stack<string>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "End")
                {
                    break;
                }
                if (data == "Service")
                {
                    if (queue.Count > 0)
                    {
                        string car = queue.Dequeue();
                        Console.WriteLine("Vehicle {0} got served.", car);
                        stack.Push(car);
                    }
                }
                else if (data == "History")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(string.Join(", ", stack));
                    }
                }
                else
                {
                    string car = data.Split('-').Last();
                    if (queue.Contains(car))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    if (stack.Contains(car))
                    {
                        Console.WriteLine("Served.");
                    }
                }
            }
            if (queue.Count != 0)
            {
                Console.WriteLine("Vehicles for service: {0}", string.Join(", ", queue));
            }

            Console.WriteLine("Served vehicles: {0}", string.Join(", ", stack));
        }
    }
}
