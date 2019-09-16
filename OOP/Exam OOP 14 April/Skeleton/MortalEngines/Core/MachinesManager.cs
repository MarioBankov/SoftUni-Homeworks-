namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Entities.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private IList<IPilot> pilots;
        private IList<IMachine> machines;

        public MachinesManager(IList<IPilot> pilots,IList<IMachine> machines)
        {
            this.pilots = pilots;
            this.machines = machines;

        }
        public string HirePilot(string name)
        {
            IPilot pilot = new Pilot(name);
            string message = string.Empty;

            if (pilots.Contains(pilot))
            {
                message = $"Pilot {name} is hired already";
            }
            else
            {
                pilots.Add(pilot);
                message = $"Pilot {name} hired";
            }
            return message;
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            var result = string.Empty;
            Tank tank = new Tank(name, attackPoints, defensePoints);
            if (machines.Contains(tank))
            {
                result = $"Machine {name} is manufactured already";
            }
            else
            {
                machines.Add(tank);
                result = $"Tank {name} manufactured - attack: {tank.AttackPoints}; defense: {tank.DefensePoints}";
            }

            return result;
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            string result = string.Empty;
            IFighter fighter = new Fighter(name, attackPoints, defensePoints);
            if (!machines.Contains(fighter))
            {
               result = $"Fighter {name} manufactured - attack: {fighter.AttackPoints:F2}; defense: {fighter.DefensePoints:F2}; aggressive: ON";
                machines.Add(fighter);
            }
            else
            {
                result = $"Machine {name} is manufactured already";
            }
            return result;

        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            string resilt = string.Empty;

            var pilot = pilots.FirstOrDefault(p => p.Name == selectedPilotName);
            if (pilot==null)
            {
                return $"Pilot {selectedPilotName} could not be found";

            }
            
            var machine = machines.FirstOrDefault(m => m.Name == selectedMachineName);
            if (machine==null)
            {
                return $"Machine {selectedMachineName} could not be found";

            }

            if (machine.Pilot!=null)
            {
                return $"Machine {selectedMachineName} is already occupied";
            }

            pilot.AddMachine(machine);
            return $"Pilot {selectedPilotName} engaged machine {selectedMachineName}";


        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            var attacker = machines.FirstOrDefault(m => m.Name == attackingMachineName);
            if (attacker==null)
            {
                return $"Machine {attackingMachineName} could not be found";
            }

            var defender = machines.FirstOrDefault(m => m.Name == defendingMachineName);
            if (defender == null)
            {
                return $"Machine {defendingMachineName} could not be found";
            }

            if (attacker.HealthPoints==0)
            {
                return $"Dead machine {attacker.Name} cannot attack or be attacked";
            }
            if (defender.HealthPoints==0)
            {
                return $"Dead machine {defender.Name} cannot attack or be attacked";
            }

            attacker.Attack(defender);
            return $"Machine {defender.Name} was attacked by machine {attacker.Name} - current health: {defender.HealthPoints}";
        }

        public string PilotReport(string pilotReporting)
        {
            var pilot = pilots.FirstOrDefault(p => p.Name == pilotReporting);

            return pilot.Report();
        }

        public string MachineReport(string machineName)
        {
            IMachine machine = machines.FirstOrDefault(m => m.Name == machineName);
            return machine.ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            string result = string.Empty;
            IMachine machine = machines.FirstOrDefault(m => m.Name == fighterName);

            if (machine!=null)
            {
                IFighter fighter = (IFighter)machine;
                fighter.ToggleAggressiveMode();
                result = $"Fighter {fighterName} toggled aggressive mode";
            }
            else
            {
                result = $"Machine {fighterName} could not be found";
            }
            return result;
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            IMachine machine = machines.FirstOrDefault(m => m.Name == tankName);

            string result = string.Empty;
            if (machine != null)
            {
                ITank tank = (ITank)machine;
                tank.ToggleDefenseMode();
                result = $"Tank {tank.Name} toggled defense mode";
            }
            else
            {
                result = $"Machine {tankName} could not be found";
            }
            return result;
        }
    }
}