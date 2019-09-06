using System;
using System.Collections.Generic;
using System.Linq;


namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').Reverse()
                .ToList();
            
          
            List<string> result = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string element = numbers[i];
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j]!=' ')
                    {
                        result.Add(element[j]+"");
                    }
                }
            }
           

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
