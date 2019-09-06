using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine());
            while (queue.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine("Removed {0}",queue.Dequeue());
            }
            Console.WriteLine("Last is {0}",queue.Dequeue());
        }
    }
}
