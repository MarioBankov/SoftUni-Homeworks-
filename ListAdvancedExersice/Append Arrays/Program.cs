using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|').Reverse().ToList();
            List<string> result = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                List<string> element = numbers[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int l = 0; l < element.Count; l++)
                {
                    Console.Write(element[l]+" ");
                }

            }
            
        }
    }
}
