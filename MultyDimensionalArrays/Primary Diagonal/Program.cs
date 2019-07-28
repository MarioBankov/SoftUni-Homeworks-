using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int sum = 0;
            for (int row = 0; row < size; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                sum += data[row];
                for (int col = 0; col < size; col++)
                {

                    matrix[row, col] = data[col];
                    if (row==col)
                    {
                       // sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sum);

        }
    }
}
