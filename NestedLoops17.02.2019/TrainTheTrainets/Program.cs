using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTheTrainets
{
    class Program
    {
        static void Main(string[] args)
        {

            int jury = int.Parse(Console.ReadLine());
            int counterGrades = 0;
            double sumOfAllGrades = 0;
            

            string presentation = Console.ReadLine();
            while (presentation != "Finish")
            {
                
                double avarageSum = 0;
                double avarageGrade = 0;
                for (int i = 0; i < jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfAllGrades += grade;
                    avarageSum += grade;
                    avarageGrade = avarageSum / (jury * 1.00);
                    counterGrades++;


                }
                Console.WriteLine("{0} - {1:F2}.",presentation,avarageGrade);
                presentation = Console.ReadLine();
            }
            Console.WriteLine("Student's final assessment is {0:F2}.", sumOfAllGrades / counterGrades * 1.00);
           
        }
    }
}
