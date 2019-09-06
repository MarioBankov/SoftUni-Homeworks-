using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03.The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string data = Console.ReadLine();
                var regex = @"(#|\$|\%|\*|\&)(?<name>\w+)\1=(?<length>\d+)!!(?<code>.+)";
                var match = Regex.Match(data, regex);
                if (match.Success&& int.Parse(match.Groups["length"].Value) == match.Groups["code"].Value.Length)
                {
                    var key = int.Parse(match.Groups["length"].Value);
                    var nameOFracer = match.Groups["name"].Value;
                    var geoCode = string.Empty;
                   
                    for (int j = 0; j < match.Groups["code"].Value.Length; j++)
                    {
                        geoCode+= (char)(match.Groups["code"].Value[j] + key);
                    }
                    Console.WriteLine($"Coordinates found! {nameOFracer} -> {geoCode}");
                    break;
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
