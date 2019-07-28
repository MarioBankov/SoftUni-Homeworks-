using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIX
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumbr = int.Parse(Console.ReadLine());
            int thirhNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            for (int a = firstNumber; a <= secondNumbr; a++) 
            {
                for (int b = firstNumber; b <= secondNumbr; b++) 
                {
                    for (int c = thirhNumber; c <= fourthNumber; c++) 
                    {
                        for (int d = thirhNumber; d <= fourthNumber; d++) 
                        {
                            bool check1 = a != b;
                            bool check2 = c != d;
                            
                            if (check1&&check2&&(a+d)==(b+c))
                            {
                                Console.WriteLine("{0}{1}",a,b);
                                Console.WriteLine("{0}{1}", c, d);
                                Console.WriteLine();
                            }


                        }
                    }
                }
            }
        }
    }
}
