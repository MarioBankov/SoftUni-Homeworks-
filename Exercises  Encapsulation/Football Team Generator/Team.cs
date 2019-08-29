using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator
{
    public class Team
    {
        private List<Player> players;
        private string name;
        public Team(string name )
        {
            this.Name = name;
            players = new List<Player>();
        }
        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Rating { get => CalculateRating(); }

        private int CalculateRating()
        {
            double total = 0;
            foreach (var item in players)
            {
                total += item.SkillLevel;
            }
            return (int)Math.Round(total);
        }

        public void  AddPlayer(Player p)
        {
            players.Add(p);
        }
        public void RemovePlayer(string name)
        {
            Player playerToRemove = players.FirstOrDefault(x => x.Name == name);
            if (playerToRemove == null)
            {
                throw new InvalidOperationException($"Player {name} is not in {this.name} team.");
            }
            else
            {
                players.Remove(playerToRemove);
            }
            
           
        }
    }
}
