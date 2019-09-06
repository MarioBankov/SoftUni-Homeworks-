using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForParty = double.Parse(Console.ReadLine());
            int loveMesages = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keyChains = int.Parse(Console.ReadLine());
            int pictures = int.Parse(Console.ReadLine());
            int luck = int.Parse(Console.ReadLine());

            double income = (loveMesages * 0.60) + (roses * 7.20) + (3.60 * keyChains) + (18.20 * pictures) + (luck * 22);
            int count = loveMesages + roses + keyChains + pictures + luck;
            if (count>=25)
            {
                income = income - (income * 0.35);
            }
            income = income - (income * 0.10);
            if (income>=moneyForParty)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", income-moneyForParty );
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.",moneyForParty-income);
            }

        
        }
    }
}
