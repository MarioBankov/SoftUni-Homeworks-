using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 6];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
