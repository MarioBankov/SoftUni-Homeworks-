using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, rows];
            int primaryDiagona = 0;
            int seconderyDiagonal = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = data[j];
                   
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagona += matrix[i, i];
                seconderyDiagonal += matrix[i, matrix.GetLength(0)-1 - i];
            }
            Console.WriteLine(Math.Abs(primaryDiagona-seconderyDiagonal));

        }
    }
}
