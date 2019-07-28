using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TeamWork
{
    public class Team
    {
        public Team(string creatorName, string teamName)
        {
            CreatorName = creatorName;
            TeamName = teamName;
            Users = new List<string>();
        }
        public string CreatorName { get; set; }
        public string TeamName { get; set; }
        public List<string> Users { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamsToRegister = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamsToRegister; i++)
            {


                string[] CreatorAndTeam = Console.ReadLine().Split('-');

                string creatorName = CreatorAndTeam[0];
                string teamName = CreatorAndTeam[1];

                Team team = new Team(creatorName, teamName);
                bool isCreatorAlredyExist = teams.Any(x => x.CreatorName == creatorName);
                bool isTeamAlreadyExist = teams.Any(x => x.TeamName == teamName);
                if (isCreatorAlredyExist)
                {
                    Console.WriteLine("{0} cannot create another team!", creatorName);
                }
                if (isTeamAlreadyExist)
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                }
                if (isCreatorAlredyExist == false && isTeamAlreadyExist == false)
                {
                    teams.Add(team);
                    Console.WriteLine("Team {0} has been created by {1}!", teamName, creatorName);
                }

            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }

                string[] data = Regex.Split(input, @"\->");
                string user = data[0];
                string teamToJoin = data[1];

                bool isTeamExist = teams.Any(x => x.TeamName == teamToJoin);
                bool isUserExist = teams.Any(x => x.Users.Contains(user));
                bool isCreatorExist = teams.Any(x => x.CreatorName == user);

                if (isTeamExist == false)
                {
                    Console.WriteLine("Team {0} does not exist!", teamToJoin);
                }
                
                else if (isUserExist || isCreatorExist)
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", user, teamToJoin);
                }
                if (isTeamExist && isUserExist == false && isCreatorExist == false)
                {
                    int index = teams.FindIndex(x => x.TeamName == teamToJoin);
                    teams[index].Users.Add(user);
                }

            }
            var disband = teams.Where(x => x.Users.Count == 0).ToList();
            foreach (var item in teams.Where(x => x.Users.Count >= 1).OrderByDescending(x=>x.Users.Count).ThenBy(x=>x.TeamName))
            {

                Console.WriteLine("{0}", item.TeamName);
                Console.WriteLine("- {0}", item.CreatorName);
                foreach (var itemm in item.Users)
                {
                    Console.WriteLine("-- {0}", itemm);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in disband.OrderBy(x=>x.TeamName))
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
}
