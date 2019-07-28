using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var users =new  Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[1];
                if (input.Length==3)
                {
                    string plateNumber = input[2];
                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, plateNumber);
                        Console.WriteLine("{0} registered {1} successfully",name,plateNumber);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}",users[name]);
                    }
                }
                else
                {
                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine("{0} unregistered successfully",name);
                        users.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: user {0} not found",name);
                    }
                }
            }
            foreach (var item in users)
            {
                Console.WriteLine("{0} => {1}",item.Key,item.Value);
            }
        }
    }
}
