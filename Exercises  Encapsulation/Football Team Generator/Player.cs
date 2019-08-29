using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Football_Team_Generator
{
    public class Player
    {
        private string name;
        private int enurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Player(string name, int endurance,int sprint,int dribble,int passing,int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Shooting = shooting;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public int Endurance
        {
            get => enurance;
             private set
            {
                if (value<0||value>100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }
                this.enurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
           private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                }
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => passing;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => shooting;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                }
                this.shooting = value;
            }
        }
        public int SkillLevel { get => CalculateSkillLevel(); }

        private int CalculateSkillLevel()
        {
            var result = (double)(this.enurance + this.sprint + this.dribble + this.shooting + this.passing) / 5;
            return (int)Math.Round(result);
        }
    }
}
