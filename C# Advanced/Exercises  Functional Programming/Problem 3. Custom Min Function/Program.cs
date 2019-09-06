using System;
using System.Linq;

namespace Problem_3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> FindSmalles = x =>
            {
                int result = int.MaxValue;
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] < result)
                    {
                        result = x[i];
                    }
                }
                return result;
            };
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(FindSmalles(numbers));
        }
    }
}
