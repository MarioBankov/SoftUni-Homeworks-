using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private  readonly List<ISoldier> privates;
        public LieutenantGeneral(string id, string firstName, string LastName, decimal salary) 
            : base(id, firstName, LastName, salary)
        {
            privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates => privates;

        public void AddPrivate(ISoldier @private)
        {
            privates.Add(@private);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString()).AppendLine("Privates :");
            foreach (var item in privates)
            {
                sb.AppendLine($"  {item.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
