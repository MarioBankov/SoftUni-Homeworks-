using System;

namespace Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = flourPrice * 0.75;
            double milkPrice = (flourPrice + (flourPrice * 0.25))/4;
            double cozunacPrice = flourPrice + eggPrice + milkPrice;
            int count = (int)(budget / cozunacPrice);
            int eggCount = 0;
            int cozunakCount = 0;

            double moneyLeft = budget - (count * cozunacPrice);
            int i = 1;
            while (budget>cozunacPrice)
            {
                budget -= cozunacPrice;
                eggCount += 3;
                cozunakCount++;
                if (i%3==0)
                {
                    eggCount -= (cozunakCount - 2);
                }
                i++;

            }
            Console.WriteLine("You made {0} cozonacs! Now you have {1} eggs and {2:F2}BGN left.",
                cozunakCount,eggCount,budget);

        }
    }
}
