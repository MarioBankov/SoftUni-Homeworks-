using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator
{
    public class Engine
    {
        private List<Team> teams;

        public Engine()
        {
            teams = new List<Team>();
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    string[] data = Console.ReadLine().Split(';');
                    if (data[0] == "End")
                    {
                        break;
                    }
                    if (data[0] == "Team")
                    {
                        Team t = new Team(data[1]);
                        teams.Add(t);
                    }
                    else if (data[0] == "Add")
                    {
                        string teamName = data[1];
                        string playerName = data[2];
                        int endurance = int.Parse(data[3]);
                        int sprint = int.Parse(data[4]);
                        int dribble = int.Parse(data[5]);
                        int passing = int.Parse(data[6]);
                        int shooting = int.Parse(data[7]);

                        Player p = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        if (teams.Where(x => x.Name == teamName).Count() != 0)
                        {
                            int index = teams.FindIndex(x => x.Name == teamName);
                            teams[index].AddPlayer(p);
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }
                    else if (data[0] == "Remove")
                    {
                        string teamName = data[1];
                        string playerName = data[2];
                        if (teams.Where(x => x.Name == teamName).Count() != 0)
                        {
                            int index = teams.FindIndex(x => x.Name == teamName);
                            teams[index].RemovePlayer(playerName);
                        }

                    }
                    else if (data[0] == "Rating")
                    {
                        string teamName = data[1];
                        Team a = teams.Where(x => x.Name == teamName).FirstOrDefault();
                        if (a != null)
                        {
                            Console.WriteLine(a.Rating);
                        }

                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
