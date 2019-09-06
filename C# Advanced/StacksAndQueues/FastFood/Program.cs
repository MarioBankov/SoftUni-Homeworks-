using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            int biggestOrder;
            if (queue.Count>0)
            {
                biggestOrder = queue.Max();
            }
            else
            {
                biggestOrder = 0;
            }
            
            for (int i = 0; i < orders.Length; i++)
            {
                int currentorder = queue.Peek();
                if (food-currentorder>=0)
                {
                    food -= currentorder;
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine(biggestOrder);
                    Console.WriteLine("Orders left: {0}",string.Join(" ",queue));
                    return;
                }
            }
            Console.WriteLine(biggestOrder);
            Console.WriteLine("Orders complete");

        }
    }
}
