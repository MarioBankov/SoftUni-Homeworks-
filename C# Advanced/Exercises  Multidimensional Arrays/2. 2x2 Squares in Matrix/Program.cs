using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
          
           
            char[,] matrix = new char[size.First(), size.Last()];
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0) ; i++)
            {
                string[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = char.Parse(data[j]);
                }
            }
         
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    char a = matrix[row, col];
                    if (matrix[row,col+1]==a&&matrix[row+1,col]==a&&matrix[row+1,col+1]==a)
                    {
                        count++;
                    }
                }
            }
           
           
                Console.WriteLine(count);
            
        }
    }
}
