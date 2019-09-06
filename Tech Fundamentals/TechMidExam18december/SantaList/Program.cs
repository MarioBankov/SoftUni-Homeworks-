using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> badKids = Console.ReadLine().Split('&').ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data== "Finished!")
                {
                    break;
                }
                string command = data.Split()[0];
                if (command=="Bad")
                {
                    if (badKids.Contains(data.Split()[1])==false)
                    {
                        badKids.Insert(0, data.Split()[1]);
                    }
                }
                else if (command=="Good")
                {
                    if (badKids.Contains(data.Split()[1]))
                    {
                        badKids.Remove(data.Split()[1]);
                    }
                }
                else if (command=="Rename")
                {
                    string oldName= data.Split()[1];
                    string newName= data.Split()[2];
                    if (badKids.Contains(oldName))
                    {
                        int index = badKids.IndexOf(oldName);
                        badKids[index] = newName;
                    }
                }
                else if (command=="Rearrange")
                {
                    string name = data.Split()[1];
                    if (badKids.Contains(name)) 
                    {
                        int index = badKids.IndexOf(name);
                        badKids.RemoveAt(index);
                        badKids.Add(name);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",badKids));
        }
    }
}
