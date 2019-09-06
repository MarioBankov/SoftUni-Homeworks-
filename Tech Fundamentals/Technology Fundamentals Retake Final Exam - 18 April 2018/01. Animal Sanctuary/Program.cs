using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace _01._Animal_Sanctuary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalKg = 0;
            for (int i = 0; i < n; i++)
            {
                var pattern = @"^n:(?<animalname>[^;]+);t:(?<animalkind>[^;]+);c--(?<animalcountry>[A-Za-z\s]+)$";
                string input = Console.ReadLine();
                var match = Regex.Match(input, pattern);
                if (match.Groups["animalname"].Value.Contains(';')|| match.Groups["animalkind"].Value.Contains(";"))
                {
                    continue;
                }
                if (match.Success)
                {
                    var name = match.Groups["animalname"].Value.Where(x => char.IsLetter(x)||x==' ').ToArray();
                    var type = match.Groups["animalkind"].Value.Where(x => char.IsLetter(x)||x== ' ').ToArray();
                    Console.WriteLine($"{string.Join("",name)} is a {string.Join("",type)} from {match.Groups["animalcountry"].Value}");
                    int kg = match.Groups["animalname"].Value.Where(x => char.IsDigit(x)).Select(x=>int.Parse(x.ToString())).Sum()+
                       match.Groups["animalkind"].Value.Where(x => char.IsDigit(x)).Select(x => int.Parse(x.ToString())).Sum();
                    totalKg += kg;
                }
            }
            Console.WriteLine("Total weight of animals: {0}KG",totalKg);
        }
    }
}
