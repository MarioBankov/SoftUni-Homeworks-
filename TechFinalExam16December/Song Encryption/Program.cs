using System;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="end")
                {
                    break;
                }
                string[] input = data.Split(':');
                string artist = input[0];
                string song = input[1];
                string pattern = @"[A-Z][a-z-' ]*";
                Match m = Regex.Match(artist, pattern, RegexOptions.IgnoreCase);
                if (m.Success)
                {
                    Console.WriteLine("yey");
                }
            }
        }
    }
}
