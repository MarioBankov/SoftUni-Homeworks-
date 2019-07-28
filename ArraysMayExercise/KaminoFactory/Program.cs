using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestCount = 0;
            int bestIndex = -1;
            int BestSample = 1;
            int bestSum = 0;
            int[] BestDna = new int[n];
            int sampleCount = 1;
            while (true)
            {

                string command = Console.ReadLine();

                if (command == "Clone them!")
                {
                    break;
                }
                // read current Dna
                int[] dna = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                int currentBestCount = 0;
                int currentIndex = 0;
                int currentDnaCount = 0;
                bool isBestDna = false;

                for (int i = 0; i < dna.Length; i++) //1 1 1 0 
                {                                   // 0 1 1 1
                    if (dna[i] == 1)
                    {
                        currentDnaCount++;
                    }
                    else
                    {
                        currentDnaCount = 0;
                    }                                //1 1 1 0 0 // 0 1 1 1 0
                    if (currentDnaCount > currentBestCount)
                    {
                        currentIndex = i;
                         currentBestCount=currentDnaCount;

                    }
                }

                int currentSum = dna.Sum();

                if (currentBestCount > bestCount)
                {
                    isBestDna = true;
                }
                else if (currentBestCount == bestCount)
                {
                    if (currentIndex < bestIndex)
                    {
                        isBestDna = true;
                    }
                    else if (currentIndex == bestIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            isBestDna = true;
                        }
                    }
                }
                if (isBestDna)
                {
                    BestDna = dna;
                    bestCount = currentBestCount;
                    bestIndex = currentIndex;
                    BestSample = sampleCount;
                    bestSum = currentSum;
                }
                sampleCount++;
            }
            Console.WriteLine("Best DNA sample {0} with sum: {1}.", BestSample, bestSum);
            Console.WriteLine(string.Join(" ", BestDna));


        }
    }
}
