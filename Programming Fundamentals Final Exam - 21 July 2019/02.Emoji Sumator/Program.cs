using System;using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Emoji_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int[] charArray = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            var lastLine = string.Empty;
            for (int i = 0; i < charArray.Length; i++)
            {
                lastLine += (char)charArray[i];
            }
            string regex = @" (?<=[\s])(?<dots>:(?<emoji>[a-z]{4,}):)(?=[\s,.!?])";
            var matches = Regex.Matches(text, regex);
            int points = 0;
            bool match = false;
            foreach (Match item in matches)
            {
                string emoji = item.Groups["emoji"].Value;
                if (emoji==lastLine)
                {
                    match = true;
                }
                for (int i = 0; i < emoji.Length; i++)
                {
                    points += emoji[i];
                }
            }
            if (match)
            {
                points *= 2;
            }
            
            if (matches.Count>0)
            {
                Console.WriteLine("Emojis found: {0}",string.Join(", ",matches.Select(x=>x.Groups["dots"])));
            }
            Console.WriteLine("Total Emoji Power: {0}",points);
        }
    }
}
