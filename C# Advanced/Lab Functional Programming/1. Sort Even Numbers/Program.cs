using System;
using System.Collections.Generic;
using System.Linq;
namespace _1._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine().Split(", ").Select(int.Parse).ToArray().Where(x=>x%2==0).OrderBy(n=>n)));
        }
    }
}
