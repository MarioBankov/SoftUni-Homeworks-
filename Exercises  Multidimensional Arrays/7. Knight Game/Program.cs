using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = data[j];
                }
            }
            bool isThereNightsAtackingEachOther = true;
            int removed = 0;
            while (isThereNightsAtackingEachOther)
            {


                int maxCount = 0;
                int rowToRemove = 0;
                int colToRemove = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int currentCount = 0;
                            if (IsCordinatesInRange(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsCordinatesInRange(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsCordinatesInRange(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsCordinatesInRange(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsCordinatesInRange(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsCordinatesInRange(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsCordinatesInRange(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsCordinatesInRange(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (currentCount > maxCount)
                            {
                                rowToRemove = row;
                                colToRemove = col;
                                maxCount = currentCount;
                            }
                            
                        }
                    }
                }
                if (maxCount != 0)
                {
                    matrix[rowToRemove, colToRemove] = '0';
                    removed++;
                }
                else
                {
                    isThereNightsAtackingEachOther = false;
                }
            }
            Console.WriteLine(removed);
        }

        private static bool IsCordinatesInRange(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0)&&col>=0&&col<matrix.GetLength(1)) 
            {
                return true;
            }
            return false;
        }
    }
}
