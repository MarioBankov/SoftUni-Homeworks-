using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = specialNumbers[0];
            int power = specialNumbers[1];
            
            for (int i = 0; i < numbers.Count; i++)
            {
                int start = 0;
                int end = 0;
                if (numbers[i]==number)
                {
                    start = i - power;
                    end = i + power;
                    if (i+power>numbers.Count-1)  
                    {
                        end = numbers.Count - 1;
                    }
                    if (i-power<0)
                    {
                        start = 0;
                    }
                    numbers.RemoveRange(start, (end - start) + 1);
                    i = -1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
