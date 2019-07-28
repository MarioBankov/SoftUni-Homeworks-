using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TeamWorkProjects
{
    public class Team
    {
        public Team(string name , string creatorName)
        {
            Name = name;
            CreatorName = creatorName;
            Memvers = new List<string>();

        }

        public string Name { get; set; }
        public string CreatorName { get; set; }
        public List<string> Memvers { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool createTwise = false;
            bool create = false;
            List<Team> teams = new List<Team>();
            int teamsToRegister = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamsToRegister; i++)
            {
                string[] creatorTeam = Console.ReadLine().Split('-');
                string creator = creatorTeam[0];
                string name = creatorTeam[1];
                var team = new Team(name, creator)
                
                foreach (var item in teams)
                {
                    if (item.Name != name)
                    {
                        create = true;
                    }
                    if (item.CreatorName != creator)
                    {
                        createTwise = true;
                    }
                }
                if (create)
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                }
                else
                {
                    Console.WriteLine($"Team {name} was already created!");
                }
                if (createTwise == false)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }



                while (true)
                {
                    bool canJoin = false;
                    string input = Console.ReadLine();
                    if (input == "end of assignment")
                    {
                        break;
                    }
                    string[] userTeam = Regex.Split(input, @"\->");
                    string user = userTeam[0];
                    string teamToJoin = userTeam[1];

                    foreach (var item in teams)
                    {
                        if (item.Name == teamToJoin)
                        {
                            canJoin = true;  
                        }
                    }
                    if (canJoin==false)
                    {
                        Console.WriteLine($"Team {teamToJoin} does not exist!");
                    }
                }

            }
        }
    }
}

