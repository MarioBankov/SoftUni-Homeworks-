using System;
using System.Numerics;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double factorialA = GetFactorial(a);
            double factorialB = GetFactorial(b);



            double result = Divide(factorialA, factorialB);
            if (result == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("{0:f2}", result);
            }
            
        }

        private static double Divide(double a, double b)
        {
            if (b == 0 || a == 0)
            {
                return 0;
            }

            double result = a / b;
            return result;
        }

        private static double GetFactorial(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            double factorial = 1;
            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
