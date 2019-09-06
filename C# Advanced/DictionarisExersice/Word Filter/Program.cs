using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n",Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList()));
        }
    }
}
