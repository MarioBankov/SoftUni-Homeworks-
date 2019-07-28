using System;
using System.Collections.Generic;
using System.Linq;

namespace Hello_France
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            List<double> result = new List<double>();
            double budget = double.Parse(Console.ReadLine());
            double spendMoney = 0;
            for (int i = 0; i < items.Count; i++)
            {
                string[] itemPrice = items[i].Split("->");
                string item = itemPrice[0];
                double price = double.Parse(itemPrice[1]);
                
                if (item=="Clothes"&&price<=50.00&&budget>=price)
                {
                    spendMoney += price;
                    budget -= price;
                    price = price + (price * 0.40);
                    result.Add(price);
                }
                else if (item=="Shoes"&&price<=35.00&&budget>=price)
                {
                    spendMoney += price;
                    budget -= price;
                    price = price + (price * 0.40);
                    result.Add(price);

                }
                else if (item== "Accessories"&&price<=20.50&&budget>=price)
                {
                    spendMoney += price;
                    budget -= price;
                    price = price + (price * 0.40);
                    result.Add(price);
                }

            }
            foreach (var item in result)
            {
                Console.Write("{0:F2}",item);
                Console.Write(" ");
            }
            Console.WriteLine();
            double profit = (result.Sum() - spendMoney);
            Console.WriteLine("Profit: {0:F2}", profit);
            if (budget+ result.Sum()>=150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }


        }
    }
}
