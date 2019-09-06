using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
   public  class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(new char[] {';','='},StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(new char[] { ';','='},StringSplitOptions.RemoveEmptyEntries);

            List<Person> buyers = new List<Person>();
            for (int i = 0; i < people.Length; i+=2)
                {
                    string name = people[i];
                decimal money = decimal.Parse(people[i + 1]);
                Person person = new Person(name, money);
                buyers.Add(person);
            }
        }
    }
}
