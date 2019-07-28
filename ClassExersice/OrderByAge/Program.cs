using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{ public class Student
    {
        public Student(string name , string id ,int age )
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                string[] tokens = input.Split();
                string name = tokens[0];
                string Id = tokens[1];
                int age = int.Parse(tokens[2]);
                var student = new Student(name, Id, age);
                students.Add(student);
            }
            foreach (var item in students.OrderBy(x=>x.Age))
            {
                Console.WriteLine("{0} with ID: {1} is {2} years old.",item.Name,item.Id,item.Age);
            }
        }
    }
}
