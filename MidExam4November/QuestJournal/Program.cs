using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestJournal
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> jurnal = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "Retire!")
                {
                    break;
                }
                string[] commands = data.Split(" - ");
                string command = commands[0];
                if (command == "Start")
                {
                    string quest = commands[1];
                    if (jurnal.Contains(quest) == false)
                    {
                        jurnal.Add(quest);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Complete")
                {
                    string quest = commands[1];
                    if (jurnal.Contains(quest))
                    {
                        jurnal.Remove(quest);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Side Quest")
                {
                    string[] questSideQuest = commands[1].Split(':');
                    string quest = questSideQuest[0];
                    string sideQuest = questSideQuest[1];
                    if (jurnal.Contains(quest) && jurnal.Contains(sideQuest) == false)
                    {
                        int index = jurnal.IndexOf(quest);
                        if (index+1>jurnal.Count)
                        {
                            jurnal.Add(sideQuest);
                        }
                        else
                        {
                            jurnal.Insert(index + 1, sideQuest);
                        }
                       
                    }
                }
                else if (command=="Renew")
                {
                    string quest = commands[1];
                    if (jurnal.Contains(quest))
                    {
                        int index = jurnal.IndexOf(quest);
                        jurnal.RemoveAt(index);
                        jurnal.Add(quest);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",jurnal));
        }
    }
}
