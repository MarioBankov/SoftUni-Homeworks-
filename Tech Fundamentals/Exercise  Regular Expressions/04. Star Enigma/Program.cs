using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            dict["A"] = new List<string>();
            dict["D"] = new List<string>();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                var newData = string.Empty;
                string data = Console.ReadLine();
                var key = 0;
                for (int k = 0; k < data.Length; k++)
                {
                    if (data[k].ToString().ToUpper() == "S" || data[k].ToString().ToUpper() == "T" || data[k].ToString().ToUpper() == "A"
                        || data[k].ToString().ToUpper() == "R")
                    {
                        key++;
                    }
                }
                for (int j = 0; j < data.Length; j++)
                {
                    newData += (char)(data[j] - key);
                }
                var planetInfoPattern = @"([^@:!\->]*)@(?<name>[A-Za-z]+)([^@:!\->]*):([0-9]+)([^@:!\->]*)!(?<atc>[AD])!([^@:!\->]*)->([0-9]+)([^@:!\->]*)";

                var match = Regex.Match(newData, planetInfoPattern);
                if (match.Success)
                {
                    string planetName = match.Groups["name"].Value;
                    string type = match.Groups["atc"].Value.ToUpper();
                    if (dict.ContainsKey(type))
                    {
                        dict[type].Add(planetName);
                    }
                }
            }

            foreach (var item in dict.OrderBy(x => x.Key).ThenBy(x => x.Value))
            {
                if (item.Key == "A")
                {
                    Console.WriteLine("Attacked planets: {0}", item.Value.Count);
                }
                else
                {
                    Console.WriteLine("Destroyed planets: {0}", item.Value.Count);
                }
                foreach (var kvp in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine("-> {0}", kvp);
                }
            }
        }
    }
}
