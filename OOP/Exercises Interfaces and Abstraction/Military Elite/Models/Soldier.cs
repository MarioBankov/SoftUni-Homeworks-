using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public  abstract class Soldier : ISoldier
    {
        public Soldier(string id, string firstName, string LastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = LastName;
        } 

        public string Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }
        public override string ToString()
        {
            return $"Name: <firstName> <lastName> Id: <{this.Id}> ";
        }


    }
}
