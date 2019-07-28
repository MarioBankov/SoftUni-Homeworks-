using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            char[] openBrakets = new char[] { '(', '[', '{' };
            bool balanced = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (openBrakets.Contains(text[i]))
                {
                    stack.Push(text[i]);
                    continue;
                }
                if (stack.Count==0)
                {
                    balanced = false;
                    break;
                }

                else
                {


                    char openBraket = stack.Pop();

                    if (text[i] == ')' && openBraket == '(')
                    {
                        balanced = true;
                    }
                    else if (text[i] == ']' && openBraket == '[')
                    {
                        balanced = true;
                    }
                    else if (text[i] == '}' && openBraket == '{')
                    {
                        balanced = true;
                    }
                    else
                    {
                        balanced = false;
                        break;
                    }


                }
            }
            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
