using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> track = Console.ReadLine().Split().Select(int.Parse).ToList();
            double leftTime = 0;
            double rightTime = 0;
            for (int i = 0; i < track.Count/2; i++)
            { 
                if (track[i]!=0)
                {
                    leftTime += track[i];
                }
                else
                {
                    leftTime = leftTime * 0.8;
                }
                if (track[track.Count-1-i]!=0)
                {
                    rightTime += track[track.Count - 1 - i];  // 34.6  // 65.6
                }
                else
                {
                    rightTime = rightTime * 0.8;
                }
            }
            
            if (leftTime > rightTime)
            {
                Console.WriteLine("The winner is right with total time: {0}", rightTime);
            }
            else
            {
                Console.WriteLine("The winner is left with total time: {0}", leftTime);
            }

        }
    }
}
