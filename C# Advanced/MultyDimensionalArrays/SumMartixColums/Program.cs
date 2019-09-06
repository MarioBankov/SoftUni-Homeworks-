using System;
using System.Linq;

namespace SumMartixColums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i <matrix.GetLength(0) ; i++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = data[j];
                }
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j,i];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
