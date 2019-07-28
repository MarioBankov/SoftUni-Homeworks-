using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tast1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            PritSmallestNumber(a, b, c);
        }
        public static void PritSmallestNumber(int a, int b, int c)
        {
            Console.WriteLine(Math.Min(Math.Min(a, b), c));
        }
    }
}
