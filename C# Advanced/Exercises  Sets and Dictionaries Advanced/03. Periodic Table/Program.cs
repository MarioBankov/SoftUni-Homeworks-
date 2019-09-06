using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int j = 0; j < elements.Length; j++)
                {
                    set.Add(elements[j]);
                }
            }
            Console.WriteLine(string.Join(" ",set.OrderBy(x=>x)));
        }
    }
}
