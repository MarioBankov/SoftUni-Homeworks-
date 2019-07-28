using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            calculate(order, quantity);


        }
        static void calculate(string text , int quantity)
        {
            switch (text)
            {
                case "coffee":
                    Console.WriteLine("{0:f2}",1.50*quantity);
                    break;
                case "water":
                    Console.WriteLine("{0:f2}",1.00*quantity);
                    break;
                case "coke":
                    Console.WriteLine("{0:f2}",1.40*quantity);
                    break;
                case "snacks":
                    Console.WriteLine("{0:f2}",2.00*quantity);
                    break;
                default:
                    break;
            }
        }
    }
}
