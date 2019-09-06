using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_11._Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            List<string> filters = new List<string>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "Print")
                {
                    break;
                }
                string[] splited = data.Split(' ', 2);
                if (splited[0] == "Add")
                {
                    filters.Add(splited[1]);
                }
                else
                {
                    if (filters.Contains(splited[1]))
                    {
                        filters.Remove(splited[1]);
                    }
                }
            }
            for (int i = 0; i < filters.Count; i++)
            {
                string command = filters[i].Split(';')[1];
                string param = filters[i].Split(';')[2];
                if (command == "Start with")
                {
                    names = names.Where(x => !x.StartsWith(param)).ToList();
                }
                else if (command == "Ends with")
                {
                    names = names.Where(x => !x.EndsWith(param)).ToList();
                }
                else if (command == "Length")
                {
                    names = names.Where(x => x.Length != int.Parse(param)).ToList();
                }
                else 
                {
                    names = names.Where(x => !x.Contains(param)).ToList();
                }
            }
            Console.WriteLine(string.Join(" ",names));
        }
    }
}
