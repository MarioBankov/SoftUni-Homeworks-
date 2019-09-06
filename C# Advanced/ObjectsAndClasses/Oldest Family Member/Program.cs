using System;
using System.Collections.Generic;
using System.Linq;

namespace Oldest_Family_Member
{
    class Program
    { 
        static void Main(string[] args)
        {
            Family family = new Family();
            family.Members = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                Person person = new Person(data[0],int.Parse(data[1]));
                family.AddMember(person);
                
            }
            Console.WriteLine(family.GetOldest().ToString());
        }
    }
    class Family
    {
        public List<Person> Members { get; set; }
        public void AddMember(Person person)
        {
            this.Members.Add(person);
        }
        public Person GetOldest()
        {
            var age = int.MinValue;
            var index = 0;
            for (int i = 0; i <Members.Count; i++)
            {
                var currentAge = Members[i].Age;
                if (age<currentAge)
                {
                    age = currentAge;
                    index = i;
                }
            }
            return Members[index];
        }
    }
    class Person
    {
        public Person(string name , int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
