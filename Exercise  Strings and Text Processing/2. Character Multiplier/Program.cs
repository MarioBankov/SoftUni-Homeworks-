using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            string first = text[0];
            string second = text[1];

            int sum = GetSumOfChars(first, second);
            Console.WriteLine(sum);
        
        }

        private static int GetSumOfChars(string first, string second)
        {
            int result = 0;
            int smallestLenght = Math.Min(first.Length, second.Length);
            for (int i = 0; i < smallestLenght; i++)
            {
                result += first[i] * second[i];
            }
            if (first.Length!=second.Length)
            {
                if ( first.Length>second.Length)
                {
                    for (int i = second.Length; i < first.Length; i++)
                    {
                        result += (int)first[i];
                    }
                }
                else
                {
                    for (int i = first.Length; i < second.Length; i++)
                    {
                        result += (int)second[i];
                    }
                }
            }
            return result;
        }
    }
}
