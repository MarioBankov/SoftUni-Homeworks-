using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string LastName,int codeNumber) 
            : base(id, firstName, LastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            return base.ToString().TrimEnd() + Environment.NewLine + $"Code Number: {this.CodeNumber}";
        }
    }
}
