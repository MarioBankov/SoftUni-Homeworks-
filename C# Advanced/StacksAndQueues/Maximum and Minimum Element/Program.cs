using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               string[] comands = Console.ReadLine().Split();
                if (comands[0]=="1")
                {
                    stack.Push(int.Parse(comands[1]));
                }
                else if (comands[0]=="2")
                {
                    if (stack.Count>0)
                    {
                        stack.Pop();
                    }
                }
                else if (comands[0]=="3"&&stack.Count>0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (comands[0] == "4" && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
