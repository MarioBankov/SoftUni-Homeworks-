using System;
using System.Collections.Generic;
using System.Text;
using MortalEngines.Entities.Contracts;

namespace MortalEngines.Entities.Models
{
    public class Tank : BaseMachine
    {
        private const double initialHealthPoints = 100;
        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, initialHealthPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenceMode { get; set; }

        public void ToggleDefenseMode()
        {
            if (DefenceMode==true)
            {
                this.DefenceMode = false;

                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                this.DefenceMode = true;

                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
        }

        public override string ToString()
        {
           string  mode = DefineMode();
           return base.ToString() + Environment.NewLine + $" *Defense: {mode}";

        }


        private string DefineMode()
        {
            string mode;
            if (DefenceMode == true)
            {
                mode = "ON";
            }
            else
            {
                mode = "OFF";
            }

            return mode;
        }

    }
}
