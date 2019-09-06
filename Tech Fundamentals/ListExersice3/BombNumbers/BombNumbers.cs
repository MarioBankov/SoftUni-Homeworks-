using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == bomb)
                {
                    int index = i - power;
                    int count = i + power;
                    if (index < 0)
                    {
                        index = 0;
                    }
                    if (count > sequence.Count - 1)
                    {
                        count = sequence.Count;

                        sequence.RemoveRange(index, count - index + 1);
                        i = 0;
                    }
                }
                Console.WriteLine(sequence.Sum());
            }
        }
    }
}