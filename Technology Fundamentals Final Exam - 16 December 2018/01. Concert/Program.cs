using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var bandMembers = new Dictionary<string, List<string>>();
            var bandTime = new Dictionary<string, int>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "start of concert")
                {
                    break;
                }
                string[] commands = data.Split("; ");
                string command = commands[0];
                if (command == "Add")
                {
                    string band = commands[1];
                    List<string> members = commands[2].Split(", ").ToList();
                    if (bandMembers.ContainsKey(band) == false)
                    {
                        bandMembers.Add(band, members);
                    }
                    else
                    {
                        for (int i = 0; i < members.Count; i++)
                        {
                            if (bandMembers[band].Contains(members[i]) == false)
                            {
                                bandMembers[band].Add(members[i]);
                            }
                        }
                    }
                    if (bandTime.ContainsKey(band) == false)
                    {
                        bandTime.Add(band, 0);
                    }

                }
                else if (command == "Play")
                {
                    string band = commands[1];
                    int time = int.Parse(commands[2]);
                    if (bandMembers.ContainsKey(band) == false)
                    {
                        bandMembers.Add(band, new List<string>());
                        bandTime.Add(band, 0);
                    }
                    if (bandTime.ContainsKey(band) == false)
                    {
                        bandTime.Add(band, time);
                    }
                    else
                    {
                        bandTime[band] += time;
                    }

                }
            }
            Console.WriteLine("Total time: {0}", bandTime.Select(x => x.Value).Sum());
            foreach (var item in bandTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
            string band1 = Console.ReadLine();
            Console.WriteLine(band1);
            if (bandMembers.ContainsKey(band1))
            {
                var members = bandMembers[band1];
                foreach (var item in members)
                {
                    Console.WriteLine("=> {0}", item);
                }
            }

        }
    }
}