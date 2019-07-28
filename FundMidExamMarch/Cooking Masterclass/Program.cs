using System;

namespace Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            double sumApron = priceApron * Math.Ceiling((students+(students*0.20)));
            double sumFlour = (priceFlour * (students - (students / 5)));
            double sumEgg = priceEgg * 10 * students;
            double total = sumApron + sumEgg + sumFlour;
            if (total<=budget)
            {
                Console.WriteLine("Items purchased for {0:F2}$.",total);
            }
            else
            {
                Console.WriteLine("{0:f2}$ more needed.",total-budget);
            }

            

        }
    }
}
