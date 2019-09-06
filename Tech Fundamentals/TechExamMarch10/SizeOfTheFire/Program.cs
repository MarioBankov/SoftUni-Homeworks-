using System;
using System.Collections.Generic;
using System.Linq;

namespace SizeOfTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('#').ToList();
            List<int> extinguished = new List<int>();
            double effort = 0;
            int water = int.Parse(Console.ReadLine());
            for (int i = 0; i < input.Count; i++)
            {
                string[] fireCell = input[i].Split(" = ");
                string type = fireCell[0];
                int fire = int.Parse(fireCell[1]);
                if (type=="High"&&fire>=81&&fire<=125&&water>=fire)
                {
                    extinguished.Add(fire);
                    water -= fire;
                    effort += fire * 0.25;
                }
                else if (type=="Medium"&& fire >= 51 && fire <= 80 && water >= fire)
                {
                    extinguished.Add(fire);
                    water -= fire;
                    effort += fire * 0.25;
                }
                else if (type=="Low" && fire >= 1 && fire <= 50 && water >= fire)
                {
                    extinguished.Add(fire);
                    water -= fire;
                    effort += fire * 0.25;
                }
            }
            Console.WriteLine("Cells:");
            foreach (var item in extinguished)
            {
                Console.WriteLine("- {0}",item);
            }
            Console.WriteLine("Effort: {0:f2}",effort);
            Console.WriteLine("Total Fire: {0}",extinguished.Sum());
        }
    }
}
