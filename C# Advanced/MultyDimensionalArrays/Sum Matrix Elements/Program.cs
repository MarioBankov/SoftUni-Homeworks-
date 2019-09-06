using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().
                Split(", ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int row = size[0];
            int col  = size[1];
            int[,] matrix = new int[row,col];
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                int[] data = Console.ReadLine().
                 Split(", ", StringSplitOptions.RemoveEmptyEntries).
                 Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = data[j];
                    sum += data[j];
                }
            }
            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(sum);

        }
    }
}
