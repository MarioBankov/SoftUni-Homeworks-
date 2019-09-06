using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Vlogger
    {
        public Vlogger(string name )
        {
            this.Name = name;
            Followers = new List<string>();
            Following = new List<string>();
        }
        public string Name { get; set; }
        public List<string>Followers { get; set; }
        public List<string>Following { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vlogger> vloggers = new List<Vlogger>();
            {
               
                while (true)
                {
                    string data = Console.ReadLine();
                    if (data == "Statistics")
                    {
                        break;
                    }
                    string[] commands = data.Split();
                    string command = commands[1];
                    if (command=="joined")
                    {
                        string name = commands[0];
                        Vlogger vlogger = new Vlogger(name);
                        if (vloggers.Any(x => x.Name == vlogger.Name) == false)
                        {
                            vloggers.Add(vlogger);
                        }
                    }
                    else
                    {
                        string name1 = commands[0];
                        string name2 = commands[2];
                        if (vloggers.Any(x=>x.Name==name1)&&vloggers.Any(x => x.Name == name2))
                        {
                            int indexName1 = vloggers.FindIndex(x => x.Name == name1);
                            int indexName2 = vloggers.FindIndex(x => x.Name == name2);
                            if (name1!=name2)
                            {
                                if (vloggers[indexName1].Following.Contains(name2)==false)
                                {
                                    vloggers[indexName1].Following.Add(name2);
                                }
                                if (vloggers[indexName2].Followers.Contains(name1) == false)
                                {
                                    vloggers[indexName2].Followers.Add(name1);
                                }
                               
                            }
                            
                        }
                    }
                }
                int i = 1;
                Console.WriteLine("The V-Logger has a total of {0} vloggers in its logs.",vloggers.Count);
                foreach (var item in vloggers.OrderByDescending(x=>x.Followers.Count).ThenBy(x=>x.Following.Count))
                {
                    Console.WriteLine("{0}. {1} : {2} followers, {3} following",i,item.Name,item.Followers.Count,item.Following.Count);
                    if (i==1)
                    {
                        foreach (var kvp in item.Followers.OrderBy(x=>x))
                        {
                            Console.WriteLine("*  {0}", kvp);
                        }
                    }
                    i++;
                }
               
            }
        }
    }
}
