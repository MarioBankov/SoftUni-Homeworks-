using System;
using System.Linq;

namespace CaminoFactori
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int index = -1;
            int count = 0;
            int iteration = 0;
            int bestIteration = 0;

            int[] BestDnA = null;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    break;
                }
                var dna = command.Split('!',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int count1 = 0;
                int index1 = -1;
                int sum1 = 0;
                int maxCount = 0;
                for (int i = 0; i < dna.Length - 1; i++)
                {
                   
                    if (dna[i] == 1)  //1101
                    {
                        count1++;
                    }
                    else
                    {
                        count1 = 0;
                    }
                    if (count1 > maxCount)
                    {
                        index1 = i;
                        maxCount = count1;
                        
                    }
                }
                sum1 = dna.Sum();
                bool IsCurrentDnaBetter = false;
                if (maxCount > count)
                {
                    IsCurrentDnaBetter = true;
                }
                else if (maxCount == count)
                {
                    if (index1 < index)
                    {
                        IsCurrentDnaBetter = true;

                    }
                }
                else if (index == index1)
                {
                    if (sum1 > sum)
                    {
                        IsCurrentDnaBetter = true;
                    }
                }
                iteration++;
                if (IsCurrentDnaBetter)
                {
                    index = index1;
                    sum = sum1;
                    count = maxCount;
                    BestDnA = dna;
                   bestIteration = iteration;
                   

                }
            }
            Console.WriteLine($"Best DNA sample {bestIteration} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", BestDnA));

        }
    }
}
