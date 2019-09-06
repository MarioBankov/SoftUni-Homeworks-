using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultyplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string first = words[0];
            string second = words[1];
            int sum = Multiply(first, second);
            Console.WriteLine(sum);
        }

        private static int Multiply(string first, string second)
        {
            int sum = 0;
            int shortest = Math.Min(first.Length, second.Length);
            for (int i = 0; i < shortest; i++) 
            {
                sum += (int)first[i] * (int)second[i];
            }
            if (first.Length>second.Length)
            {
                for (int i = 0; i < first.Length-shortest; i++)
                {
                    sum += first[shortest + i];
                }
            }
            else if (first.Length < second.Length)
            {
                for (int i = 0; i < second.Length-shortest; i++)
                {
                    sum += second[shortest + i];
                }
            }
            return sum;
        }
    }
}
