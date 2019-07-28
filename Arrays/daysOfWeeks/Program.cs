using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysOfWeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] daysOfTheWeek ={
                 "Monday",
                 "Tuesday",
                  "Wednesday ",
                  "Thursday",
                  "Friday",
                  "Saturday",
                  "Sunday",
            };
            if (n>=1&&n<=7)
            {
                Console.WriteLine(daysOfTheWeek[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
