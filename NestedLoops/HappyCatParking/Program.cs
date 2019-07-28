using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double price = 0;
            double dayprice = 0;
            


            for (int day = 1; day <= days; day++)
            {
                for (int h = 1; h <=hours; h++)
                {
                   
                    if (day % 2 == 0)
                    {
                        if (h % 2 == 1)
                        {
                            dayprice += 2.50;
                            price+= 2.50;
                        }
                        else
                        {
                            dayprice += 1.00;
                            price += 1.00;
                        }
                    }
                    else if (day % 2 == 1)
                    {
                        if (h % 2 == 0)
                        {
                            dayprice += 1.25;
                            price += 1.25;
                        }
                        else
                        {
                            price += 1.00;
                            dayprice += 1.00;
                        }

                       
                    }
                    

                }
                Console.WriteLine("Day: {0} - {1:F2} leva", day, dayprice);
                dayprice = 0;

            }
            Console.WriteLine("Total: {0:f2} leva", price);
        }

    }
}
