using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasDecor
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Stop")
                {
                    break;
                }
                for (int i = 0; i < input.Length; i++)
                {
                    sum += (int)input[i];
                    
                }
                if (sum <= budget)
                {
                    Console.WriteLine("Item successfully purchased!");
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    return;
                }
            }
            Console.WriteLine("Money left: {0}",budget-sum);
            
           
        }
    }
}
