using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllNegativeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.RemoveAll(n => n < 0);
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
