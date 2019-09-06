using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double totalWater = days * people * water;
            double totalFood = days * people * food;


            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energy -= energyLoss;

                if (i % 2 == 0)
                {
                    energy += (energy * 0.05);
                    totalWater -= (totalWater * 0.3);
                }
                if (i % 3 == 0)
                {
                    totalFood -= (totalFood / people);
                    energy += (energy * 0.1);
                }

                if (energy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }

            }

            Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
        }
    }
}