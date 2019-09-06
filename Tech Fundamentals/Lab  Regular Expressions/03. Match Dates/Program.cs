using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string regex = @"\b(?<day>\d{2})(?<sep>[\/|\.]|-)(?<mount>[A-Z][a-z]{2})\2(?<year>\d{4})\b";

            var test = Regex.Matches(text, regex);
            foreach (Match item in test)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["mount"].Value;
                string year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
