using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = array[0];
            int power = array[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;
                    if (startIndex<0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    numbers.RemoveRange(startIndex, endIndex - startIndex + 1);
                    i = 0;
                }
            }


            Console.WriteLine(numbers.Sum());
        }
    }
}
