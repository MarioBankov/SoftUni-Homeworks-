using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power

{
    class Program
    {
        static void Main(string[] args)
        {
            double power = MPower(3,4);
            Console.WriteLine(power);
        }
        static  double MPower(double a ,int b)
        {
            double power = a;
            for (int i = 1; i < b; i++)
            {
                power *= a;
            }
            return power;


        }
    }
}
