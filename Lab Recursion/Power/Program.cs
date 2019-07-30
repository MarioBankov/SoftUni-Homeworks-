using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int power = 3;
            int nPower = Power(n, power);
            Console.WriteLine(nPower);
        }

        private static int Power(int n, int power)
        {
            if (power==1)
            {
                return n;
            }
            int result = n * Power(n ,power-1);
            return result;
        }
    }
}
