using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string LastName, decimal salary)
            : base(id, firstName, LastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"Salary: {this.Salary:f2}";
        }

    }

}
