using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Enumerations;

namespace MilitaryElit
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string LastName, decimal salary, string corps)
            : base(id, firstName, LastName, salary)
        {
            ParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        private void ParseCorps(string corpsStr)
        {
            bool canParse = Enum.TryParse<Corps>(corpsStr, out Corps result);
            if (!canParse)
            {
                throw new InvalidCorpsExeption();
            }
            this.Corps = result;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps {this.Corps}";
        }
    }
}
