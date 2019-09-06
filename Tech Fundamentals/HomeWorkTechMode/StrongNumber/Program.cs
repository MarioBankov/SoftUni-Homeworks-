using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i]+"");
                int factorial = 1;

                for (int j = 1; j<=digit ;j++)
                {
                   factorial = j*factorial;
                }
                sum += factorial;
            }
            if (sum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

           
        }
    }
}
