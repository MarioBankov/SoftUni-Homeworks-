using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepair> repairs;

        public Engineer(string id, string firstName, string LastName, decimal salary, string corps)
            : base(id, firstName, LastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => this.repairs;

        public void AddRepair(IRepair repair)
        {
            this.repairs.Add(repair);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString()).AppendLine("Repairs:");
            foreach (var item in repairs)
            {
                sb.AppendLine($"  {item.ToString()}");
            }
            return base.ToString();
        }
    }
}
