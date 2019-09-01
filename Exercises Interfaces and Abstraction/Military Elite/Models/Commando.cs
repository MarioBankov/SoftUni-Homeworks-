using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly List<IMission> missions;

        public Commando(string id, string firstName, string LastName, decimal salary, string corps) 
            : base(id, firstName, LastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => this.missions;

        public void AddMissions(IMission mission)
        {
            this.missions.Add(mission);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString()).AppendLine("Missions:");
            foreach (var item in missions)
            {
                sb.AppendLine($"  {item.ToString()}"); 
            }
            return sb.ToString().Trim();
        }
    }
}
