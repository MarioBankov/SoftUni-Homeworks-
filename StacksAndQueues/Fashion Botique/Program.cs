using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Botique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            Stack<int> stack = new Stack<int>(numbers.Reverse());
            int rack = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (stack.Count > 0)
            {
                int current = stack.Pop();
                sum += current;
                if (sum == rack)
                {
                    count++;
                    sum = 0;
                    continue;
                   
                }
                else if (sum > rack)
                {
                    count++;
                    stack.Push(current);
                    sum = 0;

                }
            }
            if (sum>0)
            {
                Console.WriteLine(count+1);
            }
            else
            {
                Console.WriteLine(count);
            }
        }
    }
}
