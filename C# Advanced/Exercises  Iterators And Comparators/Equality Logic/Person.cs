using System;
using System.Collections.Generic;
using System.Text;

namespace Equality_Logic
{
   public  class Person :IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (Name!=other.Name)
            {
                return Name.CompareTo(other.Name);
            }
            if (Age!=other.Age)
            {
                return Age.CompareTo(other.Age);
            }
            return 0;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this.Name == ((Person)obj).Name && this.Age == ((Person)obj).Age;
        }
    }
}
