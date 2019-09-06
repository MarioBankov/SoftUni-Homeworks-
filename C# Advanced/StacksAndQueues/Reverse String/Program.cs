using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            var text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                stack.Push(text[i]);
            }
            Console.WriteLine(string.Join("",stack));
            
        }
    }
}
