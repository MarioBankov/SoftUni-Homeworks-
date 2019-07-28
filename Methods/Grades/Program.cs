using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGrade(double.Parse(Console.ReadLine()));
        }
        static void PrintGrade(double grade)
        {
            if (grade>=2.00&&grade<=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade<=3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade<=4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade<=5.49)
            {
                Console.WriteLine("Very Good");
            }
            else if (grade<=6.00)
            {
                Console.WriteLine("Exellent");
            }
        }
    }
}
