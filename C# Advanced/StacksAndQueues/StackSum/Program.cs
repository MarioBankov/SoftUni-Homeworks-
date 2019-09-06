using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                stack.Push(numbers[i]);
            }
            while ( true)
            {
                string data = Console.ReadLine().ToLower();
                if (data=="end")
                {
                    break;
                }
                string[] commands = data.Split();
                string command = commands[0].ToLower();
                if (command=="add")
                {
                    int first = int.Parse(commands[1]);
                    int second = int.Parse(commands[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                else
                {
                    int countToRemove = int.Parse(commands[1]);
                    if (stack.Count< countToRemove)
                    {
                        
                    }
                    else
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }

                }
            }
            Console.WriteLine("Sum: {0}",stack.Sum());
        }
    }
}
