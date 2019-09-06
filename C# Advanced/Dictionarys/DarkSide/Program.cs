using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DarkSide
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input== "Lumpawaroo")
                {
                    break;
                }
                if (input.Contains("|"))
                {
                    string[] tokens = Regex.Split(input, @" \| ");
                    string user = tokens[1];
                    string side = tokens[0];

                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, side);
                    }

                    users[user] = side;
                }
                
                else
                {
                    string[] tokens = Regex.Split(input, @" \-\> ");
                    string user = tokens[0];
                    string side = tokens[1];
                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, side);
                    }
                    users[user] = side;
                    Console.WriteLine("{0} joins the {1} side!",user,side);
                }

                
            }
            var filtered = users.GroupBy(x => x.Value).ToDictionary(x=>x.Key,x=>x.ToDictionary(y=>y.Key,y=>y.Value));

            foreach (var item in filtered)
            {
                string side = item.Key;
                Dictionary<string, string> abv = item.Value;
                Console.WriteLine("Side:{0}, Members{1}",side,abv.Count);
                foreach (var itemm in abv)
                {
                    string name = itemm.Key;
                    Console.WriteLine(name);
                }
            }
        }
    }
}
