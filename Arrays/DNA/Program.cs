using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNAlenght = int.Parse(Console.ReadLine());
            int lenght = 0;
            int startIndex = -1;
            int row = 0;
            int currentRow = 1;
            int sum = 0;
            int[] DNA = new int[DNAlenght];
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Clone them!")
                {
                    break;
                }

                int[] currentDNA = line.Split(new char[] { '!' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentSum = 0;
                int currentLength = 0;
                int currentBestLenght = 0;
                int currentEndIndex = 0;


                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i]==1)
                    {
                        currentLength++;
                        if (currentLength>currentBestLenght)
                        {
                            currentBestLenght = currentLength;
                            currentEndIndex = i;
                        }
                    }
                    else
                    {
                        currentLength = 0;
                    }
                }
                

               
            }


        }
    }
}

