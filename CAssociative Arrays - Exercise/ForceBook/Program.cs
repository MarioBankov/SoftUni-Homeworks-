using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<string>>();
            var dic = new Dictionary<string, string>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "Lumpawaroo")
                {
                    break;
                }
                if (data.Contains('|'))
                {
                    string[] arg = data.Split(" | ");
                    string forceSide = arg[0];
                    string forceUser = arg[1];
                    if (dic.ContainsKey(forceUser) == false)
                    {
                        dic.Add(forceUser, forceSide);
                       
                    }
                   
                  
                }
                else
                {
                    string[] arg = data.Split(" -> ");
                    string forceSide = arg[1];
                    string forceUser = arg[0];
                    if (dic.ContainsKey(forceUser))
                    {
                        dic[forceUser] = forceSide;
                        Console.WriteLine("{0} joins the {1} side!",forceUser,forceSide);
                    }
                    else
                    {
                        dic.Add(forceUser, forceSide);
                        Console.WriteLine("{0} joins the {1} side!", forceUser, forceSide);
                    }
                }
            }

            foreach (var item in dic)
            {
                if (result.ContainsKey(item.Value)==false)
                {
                    result.Add(item.Value, new List<string>());
                    result[item.Value].Add(item.Key);
                }
                else
                {
                    if (result[item.Value].Contains(item.Key)==false)
                    {
                        result[item.Value].Add(item.Key);
                    }
                }
            }

            foreach (var item in result.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine("Side: {0}, Members: {1}",item.Key,item.Value.Count());
                foreach (var user in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine("! {0}",user);
                }
                
                
            }
           
        }
    }

}
