using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0]=="register")
                {
                    string username = data[1];
                    string number = data[2];
                    if (dic.ContainsKey(username)==false)
                    {
                        dic.Add(username, number);
                        Console.WriteLine($"{username} registered {number} successfully");
                    }
                    else
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}",dic[username]);
                    }
                }
                else
                {
                    string username = data[1];
                    if (dic.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        dic.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
