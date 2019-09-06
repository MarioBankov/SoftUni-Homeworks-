using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
           int result =  Substact(SumOfTwo(a, b), c);
            Console.WriteLine(result);
            
        }
        static int SumOfTwo(int a , int b)
        {
           int result = a + b;
            return result;
            
        }
        static int Substact(int a ,int b)
        {
            return a - b;
        }
    }
}
