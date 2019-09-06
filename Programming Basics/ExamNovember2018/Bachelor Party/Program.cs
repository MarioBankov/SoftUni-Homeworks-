using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestSinger = int.Parse(Console.ReadLine());
            int price = 0;
            int counter = 0;

            while (true)
            {
                string imput = Console.ReadLine();
                if (imput== "The restaurant is full")
                {
                    break;
                }
                int groups = int.Parse(imput);
                counter += groups;
                if (groups<5)
                {
                    price =price+( groups * 100);
                }
                else if (groups>=5)
                {
                    price = price +(groups * 70);
                }

            }
            if (price>=guestSinger)
            {
                Console.WriteLine("You have {0} guests and {1} leva left.",counter,price-guestSinger);
            }
            else
            {
                Console.WriteLine("You have {0} guests and {1} leva income, but no singer.",counter,price);
            }

        }
    }
}
