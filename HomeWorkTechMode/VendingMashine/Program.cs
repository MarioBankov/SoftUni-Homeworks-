using System;

namespace VendingMashine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double price = 0;
            string product = string.Empty;

            while (true)
            {
                string data = Console.ReadLine();
                if (data == "Start")
                {
                    break;
                }
                double coin = double.Parse(data);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", coin);
                }
            }
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "End")
                {
                    break;
                }
                switch (data)
                {
                    case "Nuts":
                        price = 2; product = "nuts";
                        break;
                    case "Water":product = "water";
                        price = 0.7;
                        break;
                    case "Crisps":product = "crisps";
                        price = 1.5;
                        break;
                    case "Soda":product = "soda";
                        price = 0.8;
                        break;
                    case "Coke":product = "coke";
                        price = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                        
                }
                if (sum-price<0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine("Purchased {0}",product);
                    sum -= price;
                }

            }
            Console.WriteLine("Change: {0:f2}",sum);

        }
    }
}
