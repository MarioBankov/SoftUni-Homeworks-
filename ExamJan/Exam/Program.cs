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
            double gradeTotalSum = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeTotalSum += grade;
                if (grade>=5.00)
                {
                    p1++;
                }
                else if (grade>=4.00&&grade<=4.99)
                {
                    p2++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    p3++;
                }
                else if (grade<3.00)
                {
                    p4++;
                }
            }
            double avarege = gradeTotalSum / numberOfStudents * 1.00;
            double avarageP1 = ((p1*1.00) / numberOfStudents) * 100;
            double avarageP2 = (p2 *1.00/ numberOfStudents) * 100;
            double avarageP3 = (p3*1.00 / numberOfStudents) * 100;
            double avarageP4 = (p4*1.00 / numberOfStudents) * 100;
            Console.WriteLine("Top students: {0:F2}% ",avarageP1);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%",avarageP2);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", avarageP3);            Console.WriteLine("Fail: {0:F2}%",avarageP4);            Console.WriteLine("Average: {0:F2}",avarege);
        }
    }
}
