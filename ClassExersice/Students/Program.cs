using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
       public double grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string firstName = data[0];
                string secondName = data[1];
                double grade = double.Parse(data[2]);
                var student = new Student
                {
                    firstName = firstName,
                    secondName = secondName,
                    grade = grade
                };
                studentList.Add(student);
            }
            foreach (var item in studentList.OrderByDescending(x=>x.grade))
            {
                Console.WriteLine($"{item.firstName} {item.secondName}: {item.grade:f2}");
            }
        }
    }
}
