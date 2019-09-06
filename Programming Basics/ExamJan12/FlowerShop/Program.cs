using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int hr = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int lale = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string fest = Console.ReadLine();
            double priceHr = 0;
            double priceRose = 0;
            double priceLale = 0;
            double discount = 0;

            if (season == "Spring" || season == "Summer")
            {
                priceHr = 2.00;
                priceRose = 4.10;
                priceLale = 2.50;
                if (fest == "Y")
                {
                    priceHr = priceHr + (2.00 * 0.15);
                    priceRose = 4.10 + (4.10 * 0.15);
                    priceLale = 2.50 + (2.50 * 0.15);
                }
                if (lale > 7)
                {
                    discount = 0.05;
                }

            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceHr = 3.75;
                priceRose = 4.50;
                priceLale = 4.15;
                if (fest == "Y")
                {
                    priceHr = priceHr + (priceHr * 0.15);
                    priceRose = priceRose + (priceRose * 0.15);
                    priceLale = priceLale + (priceLale * 0.15);
                }
                if (rose >= 10&&season=="Winter")
                {
                    discount = 0.10;
                }

            }
            double totalprice = (hr * priceHr) + (lale * priceLale) + (priceRose * rose);
            double totalWithDiscount = totalprice - (totalprice * discount);
            
            if (hr+lale+rose>20)
            {
                totalWithDiscount = totalWithDiscount - (totalWithDiscount * 0.20);
            }
            Console.WriteLine("{0:f2}", totalWithDiscount+2);
        }
    }
}
