using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyHome
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounts = int.Parse(Console.ReadLine());
            double electro = 0;
            double water = mounts * 20;
            double internet = mounts * 15;
            double rest = 0;


            for (int i = 0; i < mounts; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electro += electricity;
                rest += (electricity + 20 + 15) + ((electricity + 20 + 15) * 0.20);
            }
            Console.WriteLine("Electricity: {0:f2} lv",electro);
            Console.WriteLine("Water: {0:f2} lv",water);
            Console.WriteLine("Internet: {0:f2} lv",internet);
            Console.WriteLine("Other: {0:F2} lv",rest);
            Console.WriteLine("Average: {0:f2} lv",(electro+water+internet+rest)/mounts);
        }
    }
}
