using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }
                string[] tokens = input.Split(':');
                string contest = tokens[0];
                string pass = tokens[1];
                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, pass);
                }
                contests[contest] = pass;
            }
            var users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {

                string input = Console.ReadLine();
                if (input == "end of submissions")
                {
                    break;
                }
                string[] tokens = Regex.Split(input, @"\=>");
                //“{contest}=&gt;{password}=&gt;{username}=&gt;{points}”
                string contest = tokens[0];
                string pass = tokens[1];
                string user = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contests.ContainsKey(contest))
                {
                    
                    if (contests[contest] == pass)
                    { 
                        if (!users.ContainsKey(user))
                        {
                            users.Add(user, new Dictionary<string, int>());
                            users[user].Add(contest, points);
                        }
                        else
                        {

                            if (users[user].ContainsKey(contest))
                            {
                                if (users[user][contest]<points)
                                {
                                    users[user][contest] = points;
                                }
                            }
                            else
                            {
                                users[user].Add(contest, points);
                            }
                        }
                    }
                }
            }
            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();
            foreach (var item in users)
            {
                usernameTotalPoints.Add(item.Key, item.Value.Values.Sum());

            }
            int bestPoits = usernameTotalPoints.Values.Max();
            foreach (var item in usernameTotalPoints)
            {
                if (item.Value==bestPoits)
                {
                    Console.WriteLine("Best candidate is {0} with total {1} points.",item.Key,item.Value);
                    Console.WriteLine("Ranking: ");
                }
            }


            foreach (var item in users.OrderBy(x=>x.Key))
            {
                string name = item.Key;
                var dic = item.Value;
                Console.WriteLine(name);
                foreach (var itemm in dic.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}",itemm.Key,itemm.Value);
                   
                }
            }
        }
    }
}
