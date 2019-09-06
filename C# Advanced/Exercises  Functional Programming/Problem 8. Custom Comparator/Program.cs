using System;
using System.Linq;

namespace Problem_8._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int, int> sort = (x, y) =>
            {
                int toRetunt = 0;
                if (x % 2 == 0 && y % 2 != 0)
                {
                    toRetunt= - 1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    toRetunt= 1;
                }
                else if (x > y)
                {
                    toRetunt= 1;
                }
                else if (x < y)
                {
                    toRetunt= - 1;
                }
                else if (x == y)
                {
                    toRetunt= 0;
                }
                return toRetunt;
            };
            Array.Sort(numbers, (x, y) => sort(x, y));
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
