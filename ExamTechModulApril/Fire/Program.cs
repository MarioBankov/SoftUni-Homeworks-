using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int water = int.Parse(Console.ReadLine());

            string[] fire = input.Split('#');
            List<int> putOut = new List<int>();
            double effort = 0; 
            for (int i = 0; i < fire.Length; i++)
            {
               string []fire1 = Regex.Split(fire[i], @"\ = ");
                string type = fire1[0];
                int fireLevel = int.Parse(fire1[1]);
                if (type == "High")   
                {
                    if (fireLevel>=81&&125>= fireLevel)
                    {
                        if (water>=fireLevel )
                        {
                            putOut.Add(fireLevel);
                            water -= fireLevel;
                            effort += fireLevel * 0.25;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (type=="Medium")
                {
                    if (fireLevel >=51 && 80 >= fireLevel)
                    {
                        if (water >= fireLevel)
                        {
                            putOut.Add(fireLevel);
                            water -= fireLevel;
                            effort += fireLevel * 0.25;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (type=="Low")
                {
                    if (fireLevel >= 1 && 50 >= fireLevel)
                    {
                        if (water >= fireLevel)
                        {
                            putOut.Add(fireLevel);
                            water -= fireLevel;
                            effort += fireLevel * 0.25;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                
            }
            Console.WriteLine("Cells:");
            foreach (var item in putOut)
            {
                Console.WriteLine(" - {0}" ,item);
            }
            
            Console.WriteLine("Effort: {0:f2}", effort);
            Console.WriteLine("Total Fire: "+putOut.Sum());
        }
    }
}
