    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contestants = Console.ReadLine().Split(", ").ToList();
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < contestants.Count; i++)
            {
                if (dict.ContainsKey(contestants[i])==false)
                {
                    dict.Add(contestants[i], 0);
                }
               
            }
            var regexLetters = @"[A-Za-z]+";
            var regexNumbers = @"\d{1}";
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="end of race")
                {
                    break;
                }
                var allLeters = Regex.Matches(data, regexLetters);
                var allNumbers = Regex.Matches(data, regexNumbers);
                string name = string.Empty;
                int distance = 0;
                foreach (Match item in allLeters)
                {
                    name += item.Value;
                }
                foreach (Match item in allNumbers)
                {
                    distance += int.Parse(item.Value);
                }
                if (dict.ContainsKey(name))
                {
                    dict[name] += distance;
                }
            }

            dict = dict.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);
            int count = 0;
            foreach (var item in dict)
            {
                if (count==0)
                {
                    Console.WriteLine("1st place: {0}",item.Key);
                }
                else if (count==1)
                {
                    Console.WriteLine("2nd place: {0}",item.Key);
                }
                else if (count==2)
                {
                    Console.WriteLine("3rd place: {0}", item.Key);
                }
                count++;
            }
            
            
        }
    }
}
