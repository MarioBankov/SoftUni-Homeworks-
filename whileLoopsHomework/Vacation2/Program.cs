using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation2
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double ownMoney = double.Parse(Console.ReadLine());

            string action = string.Empty;
            double money = 0;
            int days = 0;
            int daysSpend = 0;
            string result = string.Empty;

            while (true)
            {
                action = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                days++;
                if (action=="save")
                {
                    daysSpend = 0;
                    ownMoney += money;
                    if (ownMoney>=moneyForVacation)
                    {
                        result = $"You saved the money for {days} days.";
                        break;
                    }
                }
                if (action=="spend")
                {
                    daysSpend++;
                    ownMoney -= money;
                    if (ownMoney < 0)
                    {
                        ownMoney = 0;

                    }
                    if (daysSpend==5)
                    {
                        result = "You can't save the money." + Environment.NewLine + $"{days}";
                        break;
                    }
                }


            }
            Console.WriteLine(result);

        }
    }
}
