using System;

namespace AddAndSubstrackt
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
           int c = int.Parse(Console.ReadLine());
            int resultt = Substrackt((Sum(a, b)), c);
            Console.WriteLine(resultt);
        }

        private static int Substrackt(int a, int b)
        {
            return a-b;
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
