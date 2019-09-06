using System;

namespace PokeMone
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int targets = 0;
            double half = n * 0.5;

            while (n >= m)
            {
                n -= m;
                targets++;
                if (n == half && y!=0)
                {
                    n = n / y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targets);

        }
    }
}
