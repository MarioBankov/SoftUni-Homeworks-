using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size.First(),size.Last()];
            int[] cordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = cordinates[0];
            int col = cordinates[1];
            int radius = cordinates[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bool inRange = Math.Pow(i - row, 2) + Math.Pow(j - col, 2) <= Math.Pow(radius, 2);
                    if (inRange)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]==1)
                    {
                        
                        while (i>=1&& matrix[i - 1, j] == 0)   // i=1
                        {
                                matrix[i, j] = 0;
                                matrix[i - 1, j] = 1;
                            i--;
                        }
                    }
                }
            }
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
