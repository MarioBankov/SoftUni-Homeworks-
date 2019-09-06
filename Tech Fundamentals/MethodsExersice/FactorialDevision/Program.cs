using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDevision
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());

           ulong result = CalculateFactorial(a);
            ulong secondResult = CalculateFactorial(b);
            Console.WriteLine("{0:f2}",Devide(result, secondResult) );

        }
        static ulong CalculateFactorial(int n)
        {
           ulong result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= (ulong)i;
            }
            return result;
        }
        static double Devide(double a, double b)
        {
            return a / b;
        }
    }
}
