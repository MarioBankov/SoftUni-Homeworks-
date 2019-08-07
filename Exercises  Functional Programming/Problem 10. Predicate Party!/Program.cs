using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data =="Party!")
                {
                    break;
                }
                string[] commands = data.Split();
                string command = commands.First();
                if (command=="Remove")
                {
                    if (commands[1]=="StartsWith")
                    {
                        string toRemove = (commands[2]);
                        people = people.Where(x => !x.StartsWith(toRemove)).ToList();
                    }
                    else if (commands[1] == "EndsWith")
                    {
                        string ends = commands[2];
                        char toRemove = char.Parse(commands[2]);
                        people = people.Where(x => !x.EndsWith(ends)).ToList();
                    }
                    else if (commands[1] == "Length")
                    {
                        int length = int.Parse(commands[2]);
                        people = people.Where(x => x.Length != length).ToList();
                    }
                }
                else
                {
                    if (commands[1] == "StartsWith")
                    {
                        string toRemove = (commands[2]);
                        if (people.Any(x=>x.StartsWith(toRemove)))
                        {
                           int index = people.FindIndex(x => x.StartsWith(toRemove));
                            people.Add(people[index]);

                        }
                    }
                    else if (commands[1] == "EndsWith")
                    {
                        string ends = commands[2];
                       
                        if (people.Any(x => x.EndsWith(ends)))
                        {
                            int index = people.FindIndex(x => x.EndsWith(ends));
                            people.Add(people[index]);

                        }
                    }
                    else if (commands[1] == "Length")
                    {
                        int length = int.Parse(commands[2]);
                        if (people.Any(x => x.Length==length))
                        {
                            int index = people.FindIndex(x => x.Length==length);
                            people.Add(people[index]);

                        }
                    }
                }
            }
            people.Sort();
            Console.WriteLine(string.Join(", ",people));
        }
    }
}
