using Explicit_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Explicit_Interfaces.Model
{
    public class Citizen : IPerson, IResident
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Country { get; private set; }

        public Citizen(string name , string country, int age)
        {
            this.Age = age;
            this.Country = country;
            this.Name = name;
        }

        string IPerson.GetName()
        {
            return $"{this.Name}";
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
