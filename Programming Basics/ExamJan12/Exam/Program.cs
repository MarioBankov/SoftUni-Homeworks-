using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int fail = 0;
            int good = 0;
            int verygood = 0;
            int exelent = 0;
            double sum = 0;

            for (int i = 0; i < numberOfStudents; i++)
                
            {
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
                if (grade<3)
                {
                    fail++;
                }
                else if (grade>=3&&grade<=3.99)
                {
                    good++;
                }
                else if (grade>3.99&&grade<=4.99)
                {
                    verygood++;
                }
                else if (grade>4.99)
                {
                    exelent++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%",(exelent*1.00/numberOfStudents)*100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%",(verygood*1.00/numberOfStudents)*100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%",(good*1.00/numberOfStudents)*100);
            Console.WriteLine("Fail: {0:F2}%",(fail*1.00/numberOfStudents)*100);
            Console.WriteLine("Average: {0:F2}",sum/numberOfStudents);
        }
    }
}
