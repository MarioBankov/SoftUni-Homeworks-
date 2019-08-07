using System;
using System.Linq;

namespace _2._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);

            int[] arr = Console.ReadLine().Split(", ").Select(parser).ToArray();
            Console.WriteLine(arr.Count());
            Console.WriteLine(arr.Sum());
        }
    }
}
