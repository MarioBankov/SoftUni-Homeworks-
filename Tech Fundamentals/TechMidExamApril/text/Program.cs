using System;
using System.Collections.Generic;
using System.Linq;
namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5 };
            numbers.Insert(6, 6);
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
