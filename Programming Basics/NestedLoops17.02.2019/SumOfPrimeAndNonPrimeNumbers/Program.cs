using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimeAndNonPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrime = 0;
            while (true)
            {
                string imput = Console.ReadLine();
                if (imput=="stop")
                {
                    break;
                }
                int number = int.Parse(imput);
                if (number<0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                int counter = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number%i==0)
                    {
                        counter++;
                    }
                    
                }
                if (counter==2)
                {
                    primeSum += number;
                }
                else
                {
                    nonPrime += number;
                }
            }
            Console.WriteLine("Sum of all prime numbers is: {0}",primeSum);
            Console.WriteLine("Sum of all non prime numbers is: {0}",nonPrime);
        }
    }
}
