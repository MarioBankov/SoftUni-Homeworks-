using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?";
            string text = Console.ReadLine();
            var match = Regex.Matches(text, regex).Cast<Match>().Select(x => x.Value).ToList();
            Console.WriteLine(string.Join("\n",match));
            
        }
    }
}
