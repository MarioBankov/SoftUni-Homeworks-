using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var regex = (@"\+359([ -])2\1\d{3}\1\d{4}\b");

            var match = Regex.Matches(text, regex);
            var matchedPhones = match.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ",matchedPhones));

        }
    }
}
