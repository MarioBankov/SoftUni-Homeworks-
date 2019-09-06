using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string data = Console.ReadLine();
                if ( data =="End")
                {
                    break;
                }
                if ( data =="Paid")
                {
                    Console.WriteLine(string.Join("\n",queue));
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(data);
                }
            }
            Console.WriteLine("{0} people remaining.",queue.Count);
        }
    }
}
