using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowBalls = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for (int i = 1; i <= numberOfSnowBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowballValue1 = snowballSnow / snowballTime;
                int snowballValue = (int)Math.Pow(snowballValue1, snowballQuality);

                if (max<snowballValue)
                {
                    max = snowballValue;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;

                }
               
               
            }
            Console.WriteLine("{0} : {1} = {2} ({3})",maxSnow,maxTime,max,maxQuality);

        }
    }
}
