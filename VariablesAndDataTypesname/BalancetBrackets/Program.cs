using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancetBrackets
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int open = 0;
            int close = 0;
            string result = string.Empty;
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                result += data;
                if (data == "(")
                {
                    list.Add("(");
                    open++;
                }
                else if (data == ")")
                {
                    list.Add(")");
                    close++;
                }

            }
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] == "(" && list[i+1]=="(")
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                if (list[i] == ")" && list[i + 1] == ")")
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (result.Contains("((") || result.Contains("))"))
            {
                Console.WriteLine("UNBALANCED");
                return;
            }

            if (open == close)
            {
                Console.WriteLine("BALANCED");
            }

            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
