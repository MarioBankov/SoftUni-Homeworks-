using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine());
            double profit = 0;
            double loss = 0;
            double price = 0;
            int fishcount = 0;
            string fishName = Console.ReadLine();
            while (fishName!="Stop")
            {
                fishcount++;
                double fishkg = double.Parse(Console.ReadLine());
                for (int i = 0; i < fishName.Length; i++)
                {
                    price = (int)fishName[i];
                    if (fishcount % 3 == 0)
                    {
                        profit += price/fishkg;
                    }
                    else
                    {
                        loss += price/fishkg;
                    }


                }
                if (quota==fishcount)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }
                fishName = Console.ReadLine();



            }
            
            if (profit-loss>=0)
            {
                double diff =profit - loss;
                Console.WriteLine("Lyubo's profit from {0} fishes is {1:F2} leva.",fishcount,diff);
            }
            else
            {
                double diff = loss-profit ;
                Console.WriteLine("Lyubo lost {0:F2} leva today.",diff);
            }
        }

    }
}
