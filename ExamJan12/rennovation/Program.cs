using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rennovation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double  price = double.Parse(Console.ReadLine());
            double  workerMoney = double.Parse(Console.ReadLine());

            double area = width * length;
            double areaPeace = side * hight / 2;
            double neededPeaces = Math.Ceiling (area / areaPeace)+5;
            double totalPrice = (neededPeaces * price) + workerMoney;

            if (budget>=totalPrice)
            {
                Console.WriteLine("{0:f2} lv left.", budget-totalPrice);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",totalPrice-budget);
            }

        }
    }
}
