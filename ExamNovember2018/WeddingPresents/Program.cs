using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int presents = int.Parse(Console.ReadLine());
            int counterA = 0;
            int counterB = 0;
            int counterC = 0;
            int counterV = 0;


            for (int i = 0; i < presents; i++)
            {
                string type = Console.ReadLine();

                if (type == "A")
                {
                    counterA++;
                }
                else if (type == "B")
                {
                    counterB++;
                }
                else if (type == "V")
                {
                    counterC++;
                }
                else if (type == "G")
                {
                    counterV++;
                }

            }
            Console.WriteLine("{0:F2}%", (counterA*1.00 / presents) * 100);
            Console.WriteLine("{0:F2}%", (counterB*1.00 / presents) * 100);
            Console.WriteLine("{0:F2}%", (counterC*1.00 / presents) * 100);
            Console.WriteLine("{0:F2}%", (counterV*1.00 / presents) * 100);
            Console.WriteLine("{0:F2}%", (presents*1.00 / guests) * 100);
        }
    }
}
