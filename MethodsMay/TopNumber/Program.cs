using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int number = i;
                int sumOfDigits = SumOfDigits(number);
                bool haveOneOddDigit = CheckForOddDigit(number);
                if (sumOfDigits%8==0&&haveOneOddDigit)
                {
                    Console.WriteLine(i);
                }

            }
        }

        private static bool CheckForOddDigit(int number)
        {
            while (number!=0)
            {
                int digit = number % 10;
                if (digit%2==1)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        private static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number!=0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;

            }
            return sum;
        }
    }
}
