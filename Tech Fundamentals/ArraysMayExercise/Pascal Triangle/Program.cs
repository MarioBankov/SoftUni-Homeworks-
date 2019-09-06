using System;
using System.Collections.Generic;
using System.Text;
namespace PascalTriangle

{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int y = 0; y < n; y++)
            {
                int c = 1;

                for (int x = 0; x <= y; x++)
                {
                    System.Console.Write(c+" ");
                    c = c * (y - x) / (x + 1);

                }
                Console.WriteLine();
            }

            System.Console.WriteLine();

        }

    }

}