using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverseLinq
{
    class Program
    {
        static void Main(string[] args)
        {
          var numbers =Console.ReadLine().Split().Select(int.Parse).ToList().Where(x => x >= 0).Reverse();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
