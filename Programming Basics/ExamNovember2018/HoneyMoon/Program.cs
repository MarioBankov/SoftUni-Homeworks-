using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoneyMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double price = 0;
            double planeTiket = 0;
            double discount = 0;
            if (town == "Cairo")
            {
                planeTiket = 600;
                price = 250;
                if (nights >= 1 && nights <= 4)
                {
                    discount = 0.03;
                }
                else if (nights >= 5 && nights <= 9)
                {
                    discount = 0.05;
                }
                else if (nights >= 10 && nights <= 24)
                {
                    discount = 0.10;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    discount = 0.17;
                }
                else if (nights >= 50)
                {
                    discount = 0.30;
                }
            }
            else if (town == "Paris")
            {
                price = 150;
                planeTiket = 350;
                if (nights >= 5 && nights <= 9)
                {
                    discount = 0.07;
                }
                else if (nights >= 10 && nights <= 24)
                {
                    discount = 0.12;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    discount = 0.22;
                }
                else if (nights >= 50)
                {
                    discount = 0.30;
                }
            }
            else if (town == "Lima")
            {
                price = 400;
                planeTiket = 850;
                if (nights >= 25 && nights <= 49)
                {
                    discount = 0.19;
                }
                else if (nights >= 50)
                {
                    discount = 0.30;
                }
            }
            else if (town == "New York")
            {
                price = 300;
                planeTiket = 650;
                if (nights >= 1 && nights <= 4)
                {
                    discount = 0.03;
                }
                else if (nights >= 5 && nights <= 9)
                {
                    discount = 0.05;
                }
                else if (nights >= 10 && nights <= 24)
                {
                    discount = 0.12;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    discount = 0.19;
                }
                else if (nights >= 50)
                {
                    discount = 0.30;
                }
            }
            else if (town == "Tokyo")
            {
                price = 350;
                planeTiket = 700;
                
               
                if (nights >= 10 && nights <= 24)
                {
                    discount = 0.12;
                }
                else if (nights >= 25 && nights <= 49)
                {
                    discount = 0.17;
                }
                else if (nights >= 50)
                {
                    discount = 0.30;
                }
            }
            double total = (price * nights) * 2 + planeTiket;
            double withDiscount = total - (total * discount);
            if (budget >= withDiscount)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", budget - withDiscount);
            }
            else if (budget<withDiscount)
           
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", withDiscount - budget);
            }
        }
    }
}
