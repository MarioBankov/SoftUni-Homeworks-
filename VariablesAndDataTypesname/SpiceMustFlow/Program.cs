using System;
using System.Numerics;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
           int mine = int.Parse(Console.ReadLine());
            int collected = 0;
            int dayCount = 0;



            for (int i = mine; mine >= 100; mine -= 10)
            {
                dayCount++;
                collected += mine;
                if (collected>=26)
                {
                    collected -=26;
                }

            }
            if (collected >= 26)
            {
                collected -=26;
            }
            Console.WriteLine(dayCount);
            Console.WriteLine(collected);

        }
    }
}
