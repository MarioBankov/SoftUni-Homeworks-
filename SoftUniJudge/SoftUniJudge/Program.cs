using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniJudge
{
    class Program
    {
        static void Main(string[] args)
        {

            var users = new Dictionary<string, int>();
            var languages = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }

                string[] tokens = input.Split('-');
                if (tokens.Length > 2)
                {


                    string user = tokens[0];
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);


                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, points);
                    }
                    if (users[user] < points)
                    {
                        users[user] = points;
                    }


                    if (!languages.ContainsKey(language))
                    {
                        languages.Add(language, 0);
                    }
                    languages[language]++;
                }
                else
                {
                    string user =tokens[0];
                    if (users.ContainsKey(user))
                    {
                        users.Remove(user);
                    }
                }
            }
            foreach (var item in users.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine("Results:");
                Console.WriteLine("{0} | {1}",item.Key,item.Value);
            }
            foreach (var item in languages.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine("Submissions");
                Console.WriteLine("{0} - {1}",item.Key,item.Value);
            }
        }
    }
}
