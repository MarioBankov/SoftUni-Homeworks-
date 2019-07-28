using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotaryTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                     .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string leftSide = tickets[i].Substring(0, 10);
                string rightSide = tickets[i].Substring(10, 10);
                int lenght = 0;
                char symbol = ' ';
                for (int j = 6; j <= 10; j++)
                {
                    if (leftSide.Contains(new string('$', j)) && rightSide.Contains(new string('$', j)))
                    {
                        lenght = j;
                        symbol = '$';
                    }
                    else if (leftSide.Contains(new string('#', j)) && rightSide.Contains(new string('#', j)))
                    {
                        lenght = j;
                        symbol = '#';
                    }
                    else if (leftSide.Contains(new string('@', j)) && rightSide.Contains(new string('@', j)))
                    {
                        lenght = j;
                        symbol = '@';
                    }
                    else if (leftSide.Contains(new string('^', j)) && rightSide.Contains(new string('^', j)))
                    {
                        lenght = j;
                        symbol = '^';
                    }
                }
                if (lenght<6)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                }
                else if (lenght==10)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {lenght}{symbol} Jackpot!");
                }
                else
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {lenght}{symbol}");
                }
                
            }
        }
    }
}








