using System;
using System.Linq;
namespace Problem_6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            Predicate<int> areDevisible = x => x % number != 0;
            Console.WriteLine(string.Join(" ", numbers.Reverse().Where(x=>areDevisible(x))));
        }
    }
}
