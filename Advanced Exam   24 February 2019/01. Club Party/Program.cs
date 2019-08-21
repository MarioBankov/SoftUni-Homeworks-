using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallsCapacity = int.Parse(Console.ReadLine());
            string[] elements = Console.ReadLine().Split();
            List<int> ppl = new List<int>();
            Queue<string> queue = new Queue<string>();

            Stack<string> stack = new Stack<string>(elements);
            while (stack.Count != 0)
            {
                string element = stack.Pop();
                bool isNumber = int.TryParse(element, out int result);

                if (isNumber)
                {
                    if (queue.Count == 0)
                    {
                        continue;
                    }
                    if (ppl.Sum() + result <= hallsCapacity)
                    {
                        ppl.Add(result);
                    }
                    else
                    {
                        Console.WriteLine($"{queue.Dequeue()} -> {string.Join(", ", ppl)}");
                        ppl.Clear();
                        if (queue.Count != 0)
                        {
                            stack.Push(result.ToString());
                        }


                    }

                }
                else
                {
                    queue.Enqueue(element);
                }
            }
        }
    }
}
