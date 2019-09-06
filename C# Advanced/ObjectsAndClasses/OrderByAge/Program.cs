using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="End")
                {
                    break;
                }
                string[] arg = data.Split();
                var human = new Human(arg[0], arg[1],int.Parse( arg[2]));
                humans.Add(human);
            }
            foreach (var item in humans.OrderBy(x=>x.Age))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    class Human
    {
        public Human(string name,string id,int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;

        }
        public string Name { get; set; }
        public string Id{ get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
