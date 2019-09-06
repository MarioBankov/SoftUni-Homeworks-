using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int bigger = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bigger = Compare(number, bigger);
                
            }
            Console.WriteLine(bigger);
        }

        private static int Compare(int a, int b )
        {
            if (a>b)
            {
                return b;
            }
            return a;
        }
    }
}
