using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingGamess
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energey = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine()) * days * players;
            double food = double.Parse(Console.ReadLine()) * days * players; 

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energey = energey - energyLoss;
                if (energey <= 0)
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    energey = energey + (energey * 0.05);
                    water = water - (water * 0.30);
                }
                if (i % 3 == 0)
                {
                    food = food - (food / players);
                    energey = energey + (energey * 0.10);
                }
              
                
            }
            if (energey <= 0)
            {
                Console.WriteLine("You will run out of energy. You will be left with {0:f2} food and {1:f2} water.", food, water);
            }
            else
            {
                Console.WriteLine("You are ready for the quest. You will be left with - {0:f2} energy!", energey);
            }
        }
    }
}
