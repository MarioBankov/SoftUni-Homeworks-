using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation(2,'/',2));
        }
        static int Calculation(int a , char symbol , int b)
        {
            int result = 0;
            if (symbol=='+')
            {
                result = a + b;
            }
            else if (symbol=='-')
            {
                result = a - b;
            }
            else if (symbol=='/')
            {
                result = a / b;
            }
            else if (symbol=='*')
            {
                result = a * b;
            }
            return result;
        }
    }
}
