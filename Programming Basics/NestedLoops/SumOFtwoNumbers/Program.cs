using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOFtwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magicnumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                for (int k = a; k <= b; k++)
                {
                    counter++;
                    if (i+k==magicnumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})",counter,i,k,magicnumber);
                        return;
                    }
                  
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}",counter,magicnumber);
        }
    }
}
