using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int executed = 0;
            double sum = 0;
            int counter = 1;

            while (counter<=12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade<4.00)
                {
                    executed++;
                }
                else if (grade>=4.00)
                {
                    sum += grade;
                    counter++;
                }
                if (executed>=2)
                {
                    break;
                }
            }
            if (executed>=2)
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade");
            }
            else
            {
                double avarage = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {avarage:F2}");
            }

        }
    }
}
