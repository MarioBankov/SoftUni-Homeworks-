using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                if (command == "1")
                {
                    stack.Push(result);
                    result += commands[1];

                }
                else if (command == "2")
                {
                    stack.Push(result);
                    int count = int.Parse(commands[1]);
                    if (result.Length >= count)
                    {
                        result = result.Substring(0, result.Length - count);

                    }
                }
                else if (command == "3")
                {
                    int index = int.Parse(commands[1]) - 1; //3
                    if (index >= 0 && index < result.Length)   // a b c 
                    {
                        Console.WriteLine(result[index]);
                    }

                }
                else
                {
                    if (stack.Count != 0)
                    {
                        result = stack.Pop();
                    }
                }
            }
        }
    }
}
