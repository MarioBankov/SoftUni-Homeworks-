using MortalEngines.Common;
using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortalEngines.Entities.Models
{
    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ThrowsIfStringIsNull(value, ExceptionMessages.InvalidPilotName);
                this.name = value;
            }
        }

        public IReadOnlyCollection<IMachine> Machines => this.machines.ToList();

        public void AddMachine(IMachine machine)
        {
            Validator.ThrowsIfObjectIsNull(machine, ExceptionMessages.InvalidMachineNull);
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.name} - {this.machines.Count} machines");

            foreach (var item in machines)
            {
                sb.AppendLine($"- {item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
