using System;
using System.Linq;

namespace _9._Kamino_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] bestDNA = new int[length];
            int bestDNASample = 0;
            int sample = 0;
            int maxOnes = 0;
            int BestToghetherOnes = 0;
            int BeststartPosition = 0;

            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                int[] currentDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sample++;
                int ones = 0;
                int toghetherOnes = 0;
                int currentBestToghetherOnes = 0;
                int startPosition = 0;

                for (int i = 0; i < length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        ones++;
                        toghetherOnes++;
                    }
                    else
                    {
                        toghetherOnes = 0;
                    }

                    if (toghetherOnes > currentBestToghetherOnes)
                    {
                        currentBestToghetherOnes = toghetherOnes;
                        startPosition = i - toghetherOnes + 1;
                    }
                }

                if (currentBestToghetherOnes > BestToghetherOnes
                    || currentBestToghetherOnes == BestToghetherOnes && startPosition < BeststartPosition
                    || currentBestToghetherOnes == BestToghetherOnes && startPosition <= BeststartPosition && ones > maxOnes)
                {
                    BestToghetherOnes = currentBestToghetherOnes;
                    bestDNA = currentDNA;
                    maxOnes = ones;
                    bestDNASample = sample;
                    BeststartPosition = startPosition;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Best DNA sample {0} with sum: {1}.", bestDNASample, maxOnes);
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}