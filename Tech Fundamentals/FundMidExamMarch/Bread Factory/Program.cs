using System;
using System.Collections.Generic;
using System.Linq;

namespace Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int enegy = 100;
            int coin = 100;
            List<string> data = Console.ReadLine().Split('|').ToList();
            for (int i = 0; i < data.Count; i++)
            {
                string evenT = data[i];
                string ingredient = evenT.Split('-')[0];
                if (ingredient == "rest")
                {

                    int number = int.Parse(evenT.Split('-')[1]);
                    if (enegy + number >= 100)
                    {
                        Console.WriteLine("You gained {0} energy.", (100 - enegy));
                        enegy = 100;
                        Console.WriteLine("Current energy: {0}.", enegy);
                    }
                    else
                    {
                        Console.WriteLine("You gained {0} energy.", number);
                        enegy += number;
                        Console.WriteLine("Current energy: {0}.", enegy);

                    }

                }
                else if (ingredient == "order")
                {
                    
                    if (enegy >= 30)
                    {
                        enegy -= 30;
                        int number = int.Parse(evenT.Split('-')[1]);
                        coin += number;
                        Console.WriteLine("You earned {0} coins.", number);
                    }
                    else
                    {
                        Console.WriteLine("You had to rest!");
                        enegy += 50;

                    }
                }
                else
                {

                    int number = int.Parse(evenT.Split('-')[1]);
                    coin -= number;
                    if (coin <= 0)
                    {
                        Console.WriteLine("Closed! Cannot afford {0}.", ingredient);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You bought {0}.", ingredient);

                    }
                }

            }
            Console.WriteLine("Day completed!");
            Console.WriteLine("Coins: {0}", coin);
            Console.WriteLine("Energy: {0}", enegy);
        }


    }
}
