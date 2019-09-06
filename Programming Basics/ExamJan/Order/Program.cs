using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            double sum = 2.50;
            int counter = 0;

            string imput = Console.ReadLine();
            while (imput != "Order")
            {
                double price = double.Parse(Console.ReadLine());
                sum += price;
                counter++;
                if (sum>buget)
                {
                    Console.WriteLine("You will exceed the budget if you order this!");
                    sum -= price;
                    counter--;
                }
                imput = Console.ReadLine();
            }
            Console.WriteLine("You ordered {0} items!",counter);
            Console.WriteLine("Total: {0:F2}",sum);
        }
    }
}
