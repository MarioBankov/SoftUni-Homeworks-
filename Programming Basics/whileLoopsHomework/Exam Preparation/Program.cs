using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());
            int poorGrades = 0;
            double sum = 0;
            int problems = 0;
            string lastProblem = string.Empty;

            while (poorGrades < maxPoorGrades)
            {
                string command = Console.ReadLine();

                if (command != "Enough")
                {
                    lastProblem = command;
                    double grade = double.Parse(Console.ReadLine());
                    problems++;
                    if (grade <= 4.00)
                    {
                        poorGrades++;
                    }
                    sum += grade;
                }
                else
                {
                    break;
                }
            }
            if (poorGrades >= maxPoorGrades)
            {
                Console.WriteLine("You need a break, {0} poor grades.", poorGrades);
            }
            else
            {


                Console.WriteLine($"Average score: {sum / problems:F2}");
                Console.WriteLine($"Number of problems: {problems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
