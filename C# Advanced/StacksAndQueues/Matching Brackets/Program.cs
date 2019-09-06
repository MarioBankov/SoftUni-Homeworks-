using System;
using System.Collections.Generic;
using System.Linq;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string equation = Console.ReadLine();
           
            for (int i = 0; i < equation.Length; i++)
            {
                
                if (equation[i]=='(')
                {
                    stack.Push(i);
                }
                else if (equation[i]==')')
                {
                    int index = stack.Pop();
                    Console.WriteLine(equation.Substring(index,i-index+1));
                   
                }
               
            }
        }
    }
}
