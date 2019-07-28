using System;

using System.Collections.Generic;
using System.Linq;

namespace _01.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            var bandPlayTime = new Dictionary<string, int>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "start of concert")
                {
                    break;
                }
                string[] commands = data.Split(";");
                string command = commands.First();
                if (command.ToLower() == "add")
                {
                    string[] members = commands.Last().Split(", ");
                    string bandName = commands[1].Trim();
                    if (dict.ContainsKey(bandName) == false)
                    {
                        dict.Add(bandName, new List<string>());
                    }
                    for (int i = 0; i < members.Length; i++)
                    {
                        var member = members[i].Trim();
                        if (dict[bandName].Contains(member) == false)
                        {
                            dict[bandName].Add(member);
                        }
                    }

                }
                else
                {
                    string bandName = commands[1].Trim();
                    int time = int.Parse(commands[2]);
                    if (bandPlayTime.ContainsKey(bandName) == false)
                    {
                        bandPlayTime.Add(bandName, 0);
                    }
                    bandPlayTime[bandName] += time;
                }
            }
            Console.WriteLine("Total time: {0}", bandPlayTime.Values.Sum());
            foreach (var item in bandPlayTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
            string bandNameToPrint = Console.ReadLine();

            Console.WriteLine(bandNameToPrint);
            var list = dict[bandNameToPrint];
            for (int i = 0; i <list.Count; i++)
            {
                Console.WriteLine("=> {0}",list[i]);
            }

        }
    }
}
