using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> queue = new Queue<int[]>();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(data);

            }
            int index = 0;
            while (true)
            {
                int totalfuel = 0;
                foreach (var item in queue)
                {
                    int fuel = item[0];
                    int distance = item[1];
                    totalfuel += fuel - distance;
                    if (totalfuel<0)
                    {
                        queue.Enqueue(queue.Dequeue());
                        index++;
                        break;
                    }
                }
                if (totalfuel>=0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
