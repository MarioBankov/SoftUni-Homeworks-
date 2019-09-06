using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double sum = 2.50;
            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Order")
                {
                    break;
                }
                double price = double.Parse(Console.ReadLine());
                sum += price;
                counter++;
                if (sum>budget)
                {
                    
                    sum -= price;
                    counter--;
                    Console.WriteLine("You will exceed the budget if you order this!");
                }

            }
            Console.WriteLine("You ordered {0} items!",counter);
            Console.WriteLine("Total: {0:f2}",sum);


        }
    }
}
