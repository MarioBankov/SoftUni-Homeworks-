using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());  //20
            int budget = int.Parse(Console.ReadLine()); //1000

            int money = guests * 20;   // 400

            if (budget>=money) // 1000 400
            {
                int moneyLeft = budget - money;  // 1000-400=600
                double moneyFireworks = moneyLeft * 0.40; //600*0.40 =240
                double moneyForCherety = moneyLeft - moneyFireworks; // 600-240 =360
                Console.WriteLine("Yes! {0} lv are for fireworks and {1} lv are for donation.",Math.Round(moneyFireworks),Math.Round( moneyForCherety));
            }
            else
            {
                int diff = money - budget;
                Console.WriteLine(" They won't have enough money to pay the covert. They will need {0} lv more.",diff);
            }
        }
    }
}
