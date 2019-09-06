using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Practice_Sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data.ToLower()=="end")
                {
                    break;
                }
                string[] commands = data.Split("->");
                if (commands[0]=="Add")
                {
                    string road = commands[1];
                    string racer = commands[2];
                    if (dict.ContainsKey(road)==false)
                    {
                        dict.Add(road, new List<string>());
                       
                    }

                        dict[road].Add(racer);
                   
                }
                else if (commands[0]=="Move")
                {
                    string currendRoad = commands[1];
                    string racer = commands[2];
                    string newRoad = commands[3];
                    if (dict[currendRoad].Contains(racer)&&dict.ContainsKey(newRoad))
                    {
                        dict[currendRoad].Remove(racer);
                        dict[newRoad].Add(racer);
                    }
                }
                else if (commands[0]=="Close")
                {
                    string road = commands[1];
                    if (dict.ContainsKey(road))
                    {
                        dict.Remove(road);
                    }
                }
            }
            Console.WriteLine("Practice sessions:");
            foreach (var item in dict.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine("++{0}",kvp);
                }
            }
        }
    }
}
