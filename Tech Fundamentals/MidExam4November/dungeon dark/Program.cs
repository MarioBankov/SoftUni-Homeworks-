using System;

namespace dungeon_dark
{
    class Program
    {
        static void Main(string[] args)
        {        
            string[] rooms = Console.ReadLine().Split('|');
            int coins = 0;
            int health = 100;
            for (int i = 1; i <= rooms.Length; i++)
            {
                string[] room = rooms[i-1].Split();
                string item = room[0];
                int points = int.Parse(room[1]);
                if (item=="potion")
                {
                    
                    if (points+health<=100)
                    {
                        health += points;
                        Console.WriteLine("You healed for {0} hp.",points);
                        Console.WriteLine("Current health: {0} hp.", health);

                    }
                    else
                    {
                        Console.WriteLine("You healed for {0} hp.",100-health);
                        health = 100;
                        Console.WriteLine("Current health: {0} hp.", health);
                    }
                    
                }
                else if (item=="chest")
                {
                    coins += points;
                    Console.WriteLine("You found {0} coins.",points);

                }
                else
                {
                    if (health>points)
                    {
                        Console.WriteLine("You slayed {0}.",item);
                        health -= points;
                    }
                    else
                    {
                        Console.WriteLine("You died! Killed by {0}.",item);
                        Console.WriteLine("Best room: {0}",i);
                        return;
                    }
                    
                }

            }
            Console.WriteLine("You've made it!");
            Console.WriteLine("Coins: {0}",coins);
            Console.WriteLine("Health: {0}",health);
        }
    }
}
