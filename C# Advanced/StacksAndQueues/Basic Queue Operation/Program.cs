using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n=nsx[0];
            int s=nsx[1];
            int x=nsx[2];
            int[]numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            if (queue.Count>=s)
            {
                for (int i = 0; i < s; i++)
                {
                    queue.Dequeue();
                }
            }
            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count>0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
                
            }
        }
    }
}
