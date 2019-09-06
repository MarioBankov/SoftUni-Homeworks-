using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int k = 0; k < size; k++)
                {
                    matrix[i, k] = data[k];
                }
            }
            string[] cordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < cordinates.Length; i++)
            {
                int row = int.Parse(cordinates[i].Split(',').First());
                int col = int.Parse(cordinates[i].Split(',').Last());
                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1) && matrix[row, col]> 0)
                {

                    if (ChekCordinate(matrix, row - 1, col))
                    {
                        if (matrix[row - 1, col]>0)
                        {
                            matrix[row - 1, col] -= matrix[row, col];
                        }
                        
                    }
                    if (ChekCordinate(matrix, row - 1, col + 1))
                    {
                        if (matrix[row - 1, col + 1]>0)
                        {
                            matrix[row - 1, col + 1] -= matrix[row, col];
                        }
                       
                    }
                    if (ChekCordinate(matrix, row - 1, col - 1))
                    {
                        if (matrix[row - 1, col - 1]>0)
                        {
                            matrix[row - 1, col - 1] -= matrix[row, col];
                        }
                        
                    }
                    if (ChekCordinate(matrix, row, col + 1))
                    {
                        if (matrix[row, col + 1]>0)
                        {
                            matrix[row, col + 1] -= matrix[row, col];
                        }
                       
                    }
                    if (ChekCordinate(matrix, row, col - 1))
                    {
                        if (matrix[row, col - 1]>0)
                        {
                            matrix[row, col - 1] -= matrix[row, col];
                        }
                       
                    }
                    if (ChekCordinate(matrix, row + 1, col))
                    {
                        if (matrix[row + 1, col]>0)
                        {
                            matrix[row + 1, col] -= matrix[row, col];
                        }
                        
                    }
                    if (ChekCordinate(matrix, row + 1, col + 1))
                    {
                        if (matrix[row + 1, col + 1]>0)
                        {
                            matrix[row + 1, col + 1] -= matrix[row, col];
                        }
                       
                    }
                    if (ChekCordinate(matrix, row + 1, col - 1))
                    {
                        if (matrix[row + 1, col - 1]>0)
                        {
                            matrix[row + 1, col - 1] -= matrix[row, col];
                        }
                       
                    }
                    matrix[row, col] = 0;
                }
            }
            int liveCount = 0;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        liveCount++;
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Alive cells: {0}", liveCount);
            Console.WriteLine("Sum: {0}", sum);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool ChekCordinate(int[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
