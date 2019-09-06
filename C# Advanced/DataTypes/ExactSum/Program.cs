using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                decimal number =+ decimal.Parse(Console.ReadLine());
                if (i==n)
                {
                    Console.WriteLine(number);
                }   
            }
           
            
        }
    }
}
