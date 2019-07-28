using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());  //365.50
            double spendMoney = 0;
            int counter1 = 0;
            int couter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            while (budget>0)
            {
                string type = Console.ReadLine();
                if (type=="stop")
                {
                    
                    break;
                }
                int count = int.Parse(Console.ReadLine());
                if (type== "balloons")
                {
                    budget = budget - (0.1 * count);
                    spendMoney =spendMoney+(0.1 * count);  //1
                    counter1 += count;

                }
                else if (type== "flowers")
                {
                    budget = budget - (1.50 * count);   //22.5
                    spendMoney = spendMoney + (1.50 * count);
                    couter2 += count;
                }
                else if (type== "candles")
                {   
                    budget = budget - (0.50 * count);
                    spendMoney = spendMoney + (0.50 * count);
                    counter3 += count;
                }
                else if (type== "ribbon")
                {
                    budget = budget - (2* count);
                    spendMoney = spendMoney + (2 * count);
                    counter4 += count;
                }
            }
            if (budget <= 0)
            {
                Console.WriteLine("All money is spent!");
                Console.WriteLine("Purchased decoration is {0} balloons, {1} m ribbon, {2} flowers and {3} candles." ,counter1,counter4,couter2,counter3);
            }
            else
            {
                Console.WriteLine("Spend money: {0:F2}", spendMoney);
                Console.WriteLine("Money left: {0:F2}", budget);
                Console.WriteLine("Purchased decoration is {0} balloons, {1} m ribbon, {2} flowers and {3} candles.", counter1, counter4, couter2, counter3);
            }
        }
    }
}
