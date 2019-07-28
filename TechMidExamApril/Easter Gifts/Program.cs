using System;
using System.Collections.Generic;
using System.Linq;

namespace Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split().ToList();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "No Money")
                {
                    break;
                }
                string[] commands = data.Split();
                string command = commands[0];
                if (command == "OutOfStock")
                {
                    string gift = commands[1];

                    while (gifts.Contains(gift))
                    {
                        int index = gifts.IndexOf(gift);
                        gifts[index] = "None";
                    }
                }
                else if (command == "Required")
                {
                    string gift = commands[1];
                    int index = int.Parse(commands[2]);
                    if (index > 0 && index < gifts.Count)
                    {
                        gifts[index] = gift;
                    }
                }
                else if (command == "JustInCase")
                {
                    string gift = commands[1];
                    gifts[gifts.Count - 1] = gift;
                }
            }
            for (int i = 0; i < gifts.Count; i++)
            {
                if (gifts[i] != "None" && i == gifts.Count - 1)
                {
                    Console.Write(gifts[i]);
                    Console.WriteLine();
                    break;
                }
                if (gifts[i] != "None")
                {
                    Console.Write(gifts[i] + " ");
                }
            }
        }
    }
}
