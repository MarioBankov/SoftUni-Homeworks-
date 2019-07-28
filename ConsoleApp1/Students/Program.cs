using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Students
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string homeTowrn { get; set; }
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] info = input.Split();

                string firstName = info[0];
                string lastName = info[1];
                int age1 = int.Parse(info[2]);
                string homeTown1 = info[3];

                var pesho = new Students
                {
                    firstName = firstName,
                    lastName = lastName,
                    age = age1,
                    homeTowrn = homeTown1,
                };



                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].firstName == firstName && students[i].lastName == lastName)
                    {
                        students.Remove(students[i]);
                    }
                }
                students.Add(pesho);

            }
            string cityName = Console.ReadLine();
            foreach (var item in students)
            {
                if (item.homeTowrn == cityName)
                {
                    Console.WriteLine("{0} {1} is {2} years old .", item.firstName, item.lastName, item.age);
                }
            }
        }
    }
}
