using System;
using System.Collections.Generic;

namespace Equality_Logic
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> hashset = new HashSet<Person>();
            SortedSet<Person> sortetSet = new SortedSet<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                Person person = new Person();
                person.Name = info[0];
                person.Age = int.Parse(info[1]);
                hashset.Add(person);
                sortetSet.Add(person);
            }
            Console.WriteLine(hashset.Count);
            Console.WriteLine(sortetSet.Count);
        }
    }
}
