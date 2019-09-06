using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList().OrderByDescending(n => n).Take(3).ToList();
            Console.WriteLine(string.Join(" ",numbers));
           

        }
    }
}
