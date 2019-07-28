using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademi
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }
                students[name].Add(grade);

              
            }
            var grades = students.Where(x => x.Value.Average() >= 4.50);

            foreach (var item in grades.OrderByDescending(x => x.Value.Average()))
            {
               double avarage =item.Value.Average();

                Console.WriteLine("{0} -> {1:f2}", item.Key,avarage );
            }
        }
    }
}
