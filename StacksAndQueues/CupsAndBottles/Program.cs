using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] waterBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> Cups = new Stack<int>(cups.Reverse());
            Stack<int> wb = new Stack<int>(waterBottles);
            int wastedWater = 0;
            while (Cups.Count > 0 && wb.Count > 0)
            {
                if (Cups.Count != 0 && wb.Count != 0)
                {
                    int cup = Cups.Pop();
                    int bottle = wb.Pop();
                    if (bottle - cup >= 0)
                    {

                        wastedWater += Math.Abs(bottle - cup);
                    }
                    else
                    {
                        cup -= bottle;
                        Cups.Push(cup);
                    }

                }
            }
            if (Cups.Count==0)
            {
                Console.WriteLine("Bottles: {0}",string.Join(" ",wb));
                Console.WriteLine("Wasted litters of water: {0}",wastedWater);
            }
            else
            {
                Console.WriteLine("Cups: {0}", string.Join(" ",Cups));
                Console.WriteLine("Wasted litters of water: {0}", wastedWater);
            }

        }
    }
}
