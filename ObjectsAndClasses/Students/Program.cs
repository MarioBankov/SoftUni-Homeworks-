using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                List<string>data = Console.ReadLine().Split().ToList();
                Student student = new Student(data[0], data[1], double.Parse(data[2]));
                students.Add(student);
            }
           students= students.OrderByDescending(x => x.Grade).ToList();
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    class Student
    {
        public Student(string fistname, string secondname, double grade)
        {
            this.FirstName = fistname;
            this.SecondName = secondname;
            this.Grade = grade;

        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName}: {this.Grade:f2}";
        }
    }
}
