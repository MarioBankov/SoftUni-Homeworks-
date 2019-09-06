using System;
using System.Collections.Generic;
using System.Linq;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            List<int> data = new List<int>();
            data.Add(a);
            data.Add(b);
            data.Add(c);
            data.Sort();
            data.Reverse();
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
