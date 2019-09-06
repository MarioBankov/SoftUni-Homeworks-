using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = string.Empty;
            for (int i = 0; i < words.Count; i++)
            {
                var word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
