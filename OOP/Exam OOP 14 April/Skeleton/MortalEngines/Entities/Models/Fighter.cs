using System;
using System.Collections.Generic;
using System.Text;
using MortalEngines.Entities.Contracts;

namespace MortalEngines.Entities.Models
{
    public class Fighter : BaseMachine,IFighter
    {
        private const double initialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, initialHealthPoints)
        {
            this.ToggleAggressiveMode();
        }
        
        public bool AggressiveMode  { get; set; }

    public void ToggleAggressiveMode()
        {
            if (AggressiveMode==true)
            {
                AggressiveMode = false;
                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
            else
            {
                AggressiveMode = true;
                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
        }
        public override string ToString()
        {
            string mode = string.Empty;
            if (this.AggressiveMode == true)
            {
                mode = "ON";
            }
            else
            {
                mode = "OFF";
            }

            return base.ToString()+Environment.NewLine+ $" *Aggressive: {mode}";

        }
        
    }
}
