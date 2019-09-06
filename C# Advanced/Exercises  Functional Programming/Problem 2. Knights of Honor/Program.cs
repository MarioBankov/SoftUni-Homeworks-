using System;
using System.Linq;

namespace Problem_2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => $"Sir {x}").ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}
