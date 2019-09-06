using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingInvestment
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractLenght = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string desert = Console.ReadLine();
            int mountToPay = int.Parse(Console.ReadLine());
            double price = 0;

            if (contractLenght=="one")
            {
                if (typeContract=="Small")
                {
                    price = 9.98;
                }
                else if (typeContract=="Middle")
                {
                    price = 18.99;
                }
                else if (typeContract=="Large")
                {
                    price = 25.98;
                }
                else if (typeContract=="ExtraLarge")
                {
                    price = 35.99;
                }
               
            }
            else if (contractLenght=="two")
            {
                if (typeContract == "Small")
                {
                    price = 8.58;
                }
                else if (typeContract == "Middle")
                {
                    price = 17.09;
                }
                else if (typeContract == "Large")
                {
                    price = 23.59;
                }
                else if (typeContract == "ExtraLarge")
                {
                    price = 31.79;
                }
            }
            if (desert == "yes")
            {
                if (price <= 10)
                {
                    price += 5.50;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }
            }
            if (contractLenght=="two")
            {
                price = price - (price * 0.0375);
            }
            Console.WriteLine("{0:F2} lv.",price*mountToPay);

        }
    }
}
