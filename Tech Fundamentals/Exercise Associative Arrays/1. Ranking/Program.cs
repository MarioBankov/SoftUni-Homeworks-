using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwords = new Dictionary<string, string>();
            var users = new Dictionary<string,Dictionary<string,int>>();
            while (true)
            {
                string[] data = Console.ReadLine().Split(':');
                if (data.First() == "end of contests")
                {
                    break;
                }
                string contest = data.First();
                string pass = data.Last();
                if (passwords.ContainsKey(contest)==false)
                {
                    passwords.Add(contest, pass);
                }
                else
                {
                    passwords[contest] = pass;
                }
            }
            while (true)
            {
                string[] data = Console.ReadLine().Split("=>");
                if (data.First()== "end of submissions")
                {
                    break;
                }
                string contest = data[0];
                string pass = data[1];
                string name = data[2];
                int points = int.Parse(data[3]);
                if (passwords.ContainsKey(pass)&& passwords[contest]==pass)
                {
                    if (users.ContainsKey(name)==false)
                    {
                        users.Add(name, new Dictionary<string, int>());
                        users[name].Add(contest, points);
                    }
                    else if (users.ContainsKey(name)&&users[name].ContainsKey(contest)&&users[name][contest]<points)
                    {
                        users[name][contest] = points;
                    }
                    else if (users.ContainsKey(name) && users[name].ContainsKey(contest)==false)
                    {
                        users[name].Add(contest, points);
                    }
                }
            }
            Console.WriteLine("Ranking:");

            var dic = new Dictionary<string, int>();
            foreach (var item in users)
            {
                    dic.Add(item.Key,item.Value.Values.Sum());
            }
            int maxpoints = dic.Values.Max();

            foreach (var item in dic)
            {
                if (item.Value == maxpoints)
                {
                    Console.WriteLine("Best candidate is {0} with total {1} points.", item.Key, item.Value);
                    Console.WriteLine("Ranking: ");
                }
            }

            foreach (var item in users.OrderBy(x => x.Key))
            {
                string name = item.Key;
                var userss = item.Value;
                Console.WriteLine(name);
                foreach (var itemm in userss.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", itemm.Key, itemm.Value);

                }
            }


        }
    }
    class Student {
    }

}
