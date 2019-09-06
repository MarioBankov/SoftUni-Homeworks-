using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine ());
            
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                bool isTrue = false;
                int number = i;
                while (number != 0)
                {
                    int lastdigit = number % 10;
                    number /= 10;
                    sum += lastdigit;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isTrue = true;
                }
                    Console.WriteLine("{0}->{1}",i,isTrue);
                
            }
        }
    }
}
