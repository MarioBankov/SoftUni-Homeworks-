using System;
using System.Collections.Generic;
using System.Linq;

namespace Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                if (command=="Include")
                {
                    string shop = commands[1];
                    shops.Add(shop);
                }
                else if (command=="Visit")
                {
                    string side = commands[1];
                    int number = int.Parse(commands[2]);
                    if (number<=shops.Count)    
                    {
                        if (side=="first")
                        {
                            for (int j = 0; j < number; j++)
                            {
                                shops.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int j = 0; j < number; j++)
                            {
                                shops.RemoveAt(shops.Count-1);
                            }
                        }
                    }
                }
                else if (command== "Prefer")
                {
                    int index1 = int.Parse(commands[1]);
                    int index2 = int.Parse(commands[2]);
                    if ((index1 >= 0 && index1 < shops.Count) && (index2 >= 0 && index2 < shops.Count)) 
                    {
                        if (index1!=index2)
                        {
                            string temp = shops[index1];
                            shops[index1] = shops[index2];
                            shops[index2] = temp;
                        }
                    }
                }
                else if (command=="Place")
                {
                    string shop = commands[1];
                    int index = int.Parse(commands[2])+1;

                    if (index>0&&index<=shops.Count+1)
                    {
                        shops.Insert(index, shop);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ",shops));
        }
    }
}
