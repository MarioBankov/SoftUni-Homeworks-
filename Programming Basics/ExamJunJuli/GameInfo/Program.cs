using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            double gamePlayed = double.Parse(Console.ReadLine());
            int counter = 0;
            int counter1 = 0;
            double totalTime = 0;

            for (int i = 0; i < gamePlayed; i++)
            {
                int time = int.Parse(Console.ReadLine());
                totalTime += time;
                if (time>90&&time<=120)
                {
                    counter++;
                   
                }
                if (time > 120)
                {
                    counter1++;
                }

            }

            Console.WriteLine("{0} has played {1} minutes. Average minutes per game: {2:F2}",team,totalTime,totalTime/gamePlayed);
            Console.WriteLine("Games with penalties: {0}",counter1);
            Console.WriteLine("Games with additional time: {0}",counter);
        }

    }
}
