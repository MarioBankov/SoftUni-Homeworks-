using System;
using System.Collections.Generic;
using System.Linq;

namespace Trafic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // number of cars passed
            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="end")
                {
                    break;
                }
                if ( data =="green")
                {
                    if (queue.Count<n)
                    {
                        n = queue.Count;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        string car = queue.Dequeue();
                        stack.Push(car);
                        Console.WriteLine("{0} passed!", car);
                    }
                }
                else
                {
                    queue.Enqueue(data);
                }
            }
            Console.WriteLine("{0} cars passed the crossroads.",stack.Count);
        }
    }
}
