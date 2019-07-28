using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPass = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> userContestPass = new SortedDictionary<string, Dictionary<string, int>>();
            string input = string.Empty;
            string[] separator = { "=>" };
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = input.Split(':');
                string contest = tokens[0];
                string password = tokens[1];
                contestAndPass.Add(contest, password);
            }
            string input2 = string.Empty;
            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = input2.Split(separator, StringSplitOptions.None);
                string contest = tokens[0];
                string pass = tokens[1];
                string user = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestAndPass.ContainsKey(contest)
                    && contestAndPass.ContainsValue(pass))
                {
                    if (userContestPass.ContainsKey(user) == false)
                    {
                        userContestPass.Add(user, new Dictionary<string, int>());
                        userContestPass[user].Add(contest, points);
                    }
                    if (userContestPass[user].ContainsKey(contest))
                    {
                        if (userContestPass[user][contest] < points)
                        {
                            userContestPass[user][contest] = points;
                        }
                    }
                    else
                    {
                        userContestPass[user].Add(contest, points);
                    }
                }

            }
            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in userContestPass)
            {
                usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestName = usernameTotalPoints
                .Keys
                .Max();
            int bestPoints = usernameTotalPoints
                .Values
                .Max();

            foreach (var kvp in usernameTotalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach (var name in userContestPass)
            {
                Dictionary<string, int> dict = name.Value;
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine("{0}", name.Key);
                foreach (var kvp in dict)
                {
                    Console.WriteLine("#  {0} -> {1}", kvp.Key, kvp.Value);
                }

            }
        }
    }
}