using System;
using System.Numerics;

namespace SnowBallFight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger BestValue = 0;
            int bss = 0;
            int bst = 0;
            int bsq = 0;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime) , snowballQuality);

                if (snowballValue>BestValue)
                {
                    BestValue = snowballValue;
                    bss = snowballSnow;
                    bst = snowballTime;
                    bsq = snowballQuality;
                }

            }
            Console.WriteLine($"{bss} : {bst} = {BestValue} ({bsq})");
        }
    }
}
