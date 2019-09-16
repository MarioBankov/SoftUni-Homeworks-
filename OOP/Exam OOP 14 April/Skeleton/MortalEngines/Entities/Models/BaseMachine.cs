namespace MortalEngines.Entities.Models
{
    using MortalEngines.Common;
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseMachine : IMachine
    {
        private string name;
        private double attackPoints;
        private double defencePoints;
        private double healthPoints;
       
        private IPilot pilot;
        private IList<string> targets;



        public BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;

            this.targets = new List<string>();
        }
        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ThrowsIfStringIsNull(value, ExceptionMessages.InvalidMachineName);
                name = value;
            }
        }

        public IPilot Pilot
        {
            get => this.pilot;
            set
            {
                Validator.ThrowsIfObjectIsNull(value, ExceptionMessages.InvalidPilot);
                pilot = value;
            }
        }
        public double HealthPoints
        {
            get => this.healthPoints;
            set
            {
                if (value<0)
                {
                    value = 0;
                }
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get => this.attackPoints;
            protected set
            {
                attackPoints = value;
            }
        }


        public double DefensePoints
        {
            get => this.defencePoints;
            protected set
            {
                this.defencePoints = value;
            }
        }

        public IList<string> Targets => this.targets;

        public void Attack(IMachine target)
        {
            Validator.ThrowsIfObjectIsNull(target, ExceptionMessages.InvalidTarget);

            
            target.HealthPoints -= this.AttackPoints;

            this.targets.Add(target.Name);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            //"- {machine name}"
            //" *Type: {machine type name}"
            sb.AppendLine($"- {this.name}").AppendLine($" *Type: {this.GetType().Name}");
            sb.AppendLine($" *Health: {this.HealthPoints:f2}").AppendLine($" *Attack: {this.AttackPoints:f2}");
            sb.AppendLine($" *Defense: {this.DefensePoints:f2}");
            if (this.targets.Count==0)
            {
                sb.AppendLine("*Targets:  – None");
            }
            else
            {
                sb.AppendLine($"*Targets:  – {string.Join(",", this.targets)}");
            }

            
            return sb.ToString().TrimEnd();
        }
    }
}
