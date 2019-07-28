using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyplyEvensbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int even = GetSum(number, 1);
            int odd = GetSum(number, 0);
            int total = even * odd;
            Console.WriteLine(even);
            Console.WriteLine(odd);
        }
        static int GetSum(string number,int EvenOdd)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                
                if (i%2==EvenOdd)
                {
                    sum += int.Parse(number[i] + "");
                }
               
            }
            return sum;
        }
    }
}
