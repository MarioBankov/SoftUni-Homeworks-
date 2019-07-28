using System;


namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double ownMoney = double.Parse(Console.ReadLine());
            double moneyleft = 0;
            int spendCounter = 0;
            int daysCounter = 0;
            while (moneyleft < moneyForVacation && spendCounter < 5)
            {
                string operation = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (operation == "spend")
                {
                    spendCounter++;
                    moneyleft = ownMoney - money;
                    if (moneyleft < 0)
                    {
                        moneyleft = 0;
                    }

                    daysCounter++;
                }
                else if (operation == "save")
                {

                    moneyleft += money;
                    daysCounter++;
                    spendCounter = 0;
                }


            }
            if (spendCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            else
            {
                Console.WriteLine("You saved the money for {0} days.", daysCounter);
            }


        }
    }
}
