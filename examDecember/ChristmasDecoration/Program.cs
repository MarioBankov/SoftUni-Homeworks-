    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ChristmasDecoration
    {
        class Program
        {
            static void Main(string[] args)
            {
                int buget = int.Parse(Console.ReadLine());
                int itemcounter = 0;
            
                string thing = Console.ReadLine();
                while (thing!="Stop")
                {
                    int sum = 0;
                    for (int i = 0; i < thing.Length; i++)
                    {
                        int letterPrice = thing[i];
                        sum += letterPrice;
                
                    }
                    if (sum<=buget)
                    {
                        Console.WriteLine("Item successfully purchased!");
                        itemcounter++;
                        buget -= sum;
                    }
                    else
                    {
                        Console.WriteLine("Not enough money!");
                        break;
                    }
                    thing = Console.ReadLine();

                }
                if (thing=="Stop")
                {
                    Console.WriteLine("Money left: {0}",buget);
                }

            }
        }
    }
