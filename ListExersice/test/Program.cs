using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(',').ToList();

           for (int i = 0; i < schedule.Count; i++)
           {
               schedule[i] = schedule[i].Trim();
           }
            Console.WriteLine(string.Join("",schedule));
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine(schedule[i]);
            }




        }
    }
}
