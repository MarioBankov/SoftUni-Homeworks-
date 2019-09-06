using System;
using System.Linq;

namespace LIS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] len = new int[seq.Length];
            int[] prev = new int[seq.Length];

            for (int i = 0; i < seq.Length; i++)
            {

                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i - 1; j++)
                {
                    if (seq[i] < seq[j] && len[j] + 1 > len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = i;
                    }
                }
            }
        }
    }
}
