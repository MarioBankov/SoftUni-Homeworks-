using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wedding1
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double waterLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double shampeinLiters = double.Parse(Console.ReadLine());
            double wiskeyLiters = double.Parse(Console.ReadLine());

            double shampeinPrice = wiskeyPrice / 2;
            double winePrice = shampeinPrice * 0.40;
            double waterPrice = shampeinPrice * 0.10;

            double moneyWiskey = wiskeyPrice * wiskeyLiters;
            double moneyWater = waterPrice * waterLiters;
            double moneyWine = winePrice * wineLiters;
            double moneyShampein = shampeinPrice * shampeinLiters;
            double total = moneyWater + moneyShampein + moneyWiskey + moneyWine;
            Console.WriteLine("{0:f2}",total);

        }
    }
}
