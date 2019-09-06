    using System;
    using System.Collections.Generic;
    using System.Linq;


    namespace GamingStore
    {
        class Program
        {
            static void Main(string[] args)
            {
                double balance = double.Parse(Console.ReadLine());
                var dic = new Dictionary<string, double>();
                dic.Add("OutFall 4", 39.99);
                dic.Add("CS: OG", 15.99);
                dic.Add("Zplinter Zell", 19.99);
                dic.Add("Honored 2", 59.99);
                dic.Add("RoverWatch", 29.99);
                dic.Add("RoverWatch Origins Edition", 39.99);
                double price = 0;
                string game = string.Empty;
                double moneySpend = 0;
                while (true)
                {
                    string data = Console.ReadLine();
                    if (data=="Game Time")
                    {
                        break;
                    }
                    switch (data)
                    {
                        case "OutFall 4": price = 39.99; game = data;
                            break;
                        case "CS: OG":price = 15.99; game = data;
                            break;
                        case "Zplinter Zell":price = 19.99; game = data;
                            break;
                        case "Honored 2":price = 59.99; game = data;
                            break;
                        case "RoverWatch":price = 29.99; game = data;
                            break;
                        case "RoverWatch Origins Edition":price = 39.99; game = data;
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            continue;
                       
                    }
                    if (balance-price<0)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        balance -= price;
                        moneySpend += price;
                        Console.WriteLine("Bought {0}",game);
                    }
                    if (balance<=0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }

                }
                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}",moneySpend,balance);
            }
        }
    }
