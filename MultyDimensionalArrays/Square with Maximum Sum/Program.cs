using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().
                Split(", ",StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int a = size[0];
            int b = size[1];
            int[,] matrix = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                int[] data = Console.ReadLine().
                   Split(", ", StringSplitOptions.RemoveEmptyEntries).
                   Select(int.Parse).ToArray();

                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = data[j];
                }
            }
            int sum = int.MinValue;
            int bestRol = 0;
            int bestCol = 0;
            for (int row = 0; row <  matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col< matrix.GetLength(1)-1; col++)
                {
                    int tempSum = matrix[row, col] + matrix[row, col+1]+ matrix[row+1, col] + matrix[row+1, col + 1];
                    if (tempSum>sum)
                    {
                        sum = tempSum;
                        bestCol = col;
                        bestRol = row;
                    }
                }
            }
            Console.WriteLine("{0} {1}",matrix[bestRol,bestCol],matrix[bestRol,bestCol+1]);
            Console.WriteLine("{0} {1}",matrix[bestRol+1,bestCol],matrix[bestRol+1,bestCol+1]);
            Console.WriteLine(sum);
            
                    
            
        }
    }
}
