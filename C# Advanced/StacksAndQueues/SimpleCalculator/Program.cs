using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] data = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(data.Reverse());
            while (stack.Count>1)
            {
                int a = int.Parse(stack.Pop().ToString());
               string opr = stack.Pop();
                int b = int.Parse(stack.Pop().ToString());
                int result = 0;
                if (opr=="+")
                {
                    result = a + b;
                }
                else
                {
                    result = a - b;
                }
                stack.Push(result.ToString());
            }
            Console.WriteLine(stack.Pop());

        }
    }
}
