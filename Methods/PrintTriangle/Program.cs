using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printTiangle(n);

        }
        private static void printTiangle(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col <= row + 1; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col<n-row ; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
