using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> banWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string text = Console.ReadLine();
            for (int i = 0; i < banWords.Count; i++)
            {
                var banWord = banWords[i];
                var wordToReplace = string.Empty;
                for (int j = 0; j < banWord.Length; j++)
                {
                    wordToReplace += '*';
                }
                if (text.Contains(banWord))
                {
                     text = text.Replace(banWord, wordToReplace);
                }
            }
            Console.WriteLine(text);
        }
    }
}
