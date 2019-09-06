using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramidOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int curent = 1;
            bool isBigger = false;

            for (int rows = 1; rows <=n; rows++)  //1 do 5   //2do 5 
            {
                for (int cols = 1; cols <= rows; cols++) // 1 do 1  // 1 do 2 
                {
                    if (curent>n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(curent+" ");
                    curent++;

                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
