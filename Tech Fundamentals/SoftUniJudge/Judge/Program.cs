using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var usersPoints = new Dictionary<string, int>();
            var users = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {

                string input = Console.ReadLine();
                if (input=="no more time")
                {
                    break;
                }
                string[] tokens = Regex.Split(input, @"\ -> ");
                string user = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);
                if (!users.ContainsKey(contest))
                {
                    users.Add(contest, new Dictionary<string, int>());
                    users[contest][user] = points;
                }
                else
                {
                    if (users[contest].ContainsKey(user))
                    {
                        if (users[contest][user]<points)
                        {
                            users[contest][user] = points;
                        }
                    }
                    else
                    {
                        users[contest].Add(user, points);
                    }
                }
                
            }
            foreach (var item in users)   /// contest user points
            {
                string contest = item.Key;
                int count = item.Value.Count();
                Console.WriteLine("{0}: {1} participants", contest,count);
                var dic = users[item.Key];
                int i = 1;
                foreach (var itemm in dic.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    
                    Console.WriteLine("{0}. {1} <::> {2}",i,itemm.Key,itemm.Value);
                    i++;
                }
            }
            Console.WriteLine("Individual standings:");

            var userPoints = new Dictionary<string, int>();
            foreach (var item in users)
            {
                var names = item.Value;
                foreach (var itemm in names)
                {
                    if (usersPoints.ContainsKey(itemm.Key))
                    {
                        usersPoints[itemm.Key] += itemm.Value;
                    }
                    else
                    {
                        usersPoints.Add(itemm.Key, itemm.Value);
                    }
                    
                }
            }
            int b = 1;
            foreach (var item in usersPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine("{0}. {1} -> {2}",b,item.Key,item.Value);
                b++;
            }
           
        }
    }
}
