using System;
using System.Collections.Generic;
using System.Linq;


namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[size.First(), size.Last()];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string data = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = data[j];
                }
            }
            int[] cordinates = TakePlayerCoordinates(matrix);
            int row = cordinates[0];
            int col = cordinates[1];
            bool collision = false;
            bool playerWin = false;
            string commands = Console.ReadLine();
            for (int i = 0; i < commands.Length; i++)
            {

                if (commands[i] == 'U')  // MOVE UP
                {
                    if (CoordinatesAreValid(matrix, row - 1, col) && IsMoveSave(matrix, row - 1, col))
                    {
                        matrix[row, col] = '.';
                        matrix[row - 1, col] = 'P';
                        row = row - 1;
                    }
                    if (CoordinatesAreValid(matrix, row - 1, col) && IsMoveSave(matrix, row - 1, col) == false)
                    {
                        matrix[row, col] = '.';
                        row = row - 1;
                        collision = true;

                    }
                    if (CoordinatesAreValid(matrix, row - 1, col) == false)
                    {
                        matrix[row, col] = '.';

                        playerWin = true;

                    }

                }
                else if (commands[i] == 'D')
                {
                    if (CoordinatesAreValid(matrix, row + 1, col) && IsMoveSave(matrix, row + 1, col))
                    {
                        matrix[row, col] = '.';
                        matrix[row + 1, col] = 'P';
                        row = row + 1;
                    }
                    if (CoordinatesAreValid(matrix, row + 1, col) && IsMoveSave(matrix, row + 1, col) == false)
                    {
                        matrix[row, col] = '.';
                        row = row + 1;
                        collision = true;

                    }
                    if (CoordinatesAreValid(matrix, row + 1, col) == false)
                    {
                        matrix[row, col] = '.';
                        playerWin = true;

                    }

                }
                else if (commands[i] == 'L')
                {
                    if (CoordinatesAreValid(matrix, row, col - 1) && IsMoveSave(matrix, row, col - 1))
                    {
                        matrix[row, col] = '.';
                        matrix[row, col - 1] = 'P';
                        col = col - 1;
                    }
                    if (CoordinatesAreValid(matrix, row, col - 1) && IsMoveSave(matrix, row, col - 1) == false)
                    {
                        matrix[row, col] = '.';
                        col = col - 1;
                        collision = true;

                    }
                    if (CoordinatesAreValid(matrix, row, col - 1) == false)
                    {
                        matrix[row, col] = '.';
                        playerWin = true;

                    }

                }
                else if (commands[i] == 'R')
                {
                    if (CoordinatesAreValid(matrix, row, col + 1) && IsMoveSave(matrix, row, col + 1))
                    {
                        matrix[row, col] = '.';
                        matrix[row, col + 1] = 'P';
                        col = col + 1;
                    }
                    if (CoordinatesAreValid(matrix, row, col + 1) && IsMoveSave(matrix, row, col + 1) == false)
                    {
                        matrix[row, col] = '.';
                        col = col + 1;
                        collision = true;

                    }
                    if (CoordinatesAreValid(matrix, row, col + 1) == false)
                    {
                        matrix[row, col] = '.';
                        playerWin = true;

                    }

                }
                if (playerWin)
                {
                    List<int> bunnyCordinates = FindBunnyCordinates(matrix);
                    BunnyMultiply(matrix, bunnyCordinates);
                    break;
                }
                    List<int> bunnyCordinates1 = FindBunnyCordinates(matrix);
                    BunnyMultiply(matrix, bunnyCordinates1);
                    collision = CheckForCollision(matrix, row, col);
                    if (collision)
                    {

                        break;
                    }
            }


            if (playerWin)
            {
                List<int> bunnyCordinates = FindBunnyCordinates(matrix);
                BunnyMultiply(matrix, bunnyCordinates);
                PrintMatrix(matrix);
                Console.WriteLine("won: {0} {1}", row, col);

            }
            else
            {
                PrintMatrix(matrix);
                Console.WriteLine("dead: {0} {1}", row, col);
            }

        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsMoveSave(char[,] matrix, int row, int col)
        {
            if (matrix[row, col] != 'B')
            {
                return true;
            }
            return false;
        }

        private static bool CheckForCollision(char[,] matrix, int row, int col)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'P')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static int[] TakePlayerCoordinates(char[,] matrix)
        {
            int[] result = new int[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'P')
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

        private static List<int> FindBunnyCordinates(char[,] matrix)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'B')
                    {
                        result.Add(i);
                        result.Add(j);
                    }
                }
            }
            return result;
        }

        private static void BunnyMultiply(char[,] matrix, List<int> list)
        {
            for (int i = 0; i < list.Count; i += 2)
            {
                int row = list[i];
                int col = list[i + 1];
                if (CoordinatesAreValid(matrix, row + 1, col))
                {
                    matrix[row + 1, col] = 'B';
                }
                if (CoordinatesAreValid(matrix, row - 1, col))
                {
                    matrix[row - 1, col] = 'B';
                }
                if (CoordinatesAreValid(matrix, row, col + 1))
                {
                    matrix[row, col + 1] = 'B';
                }
                if (CoordinatesAreValid(matrix, row, col - 1))
                {
                    matrix[row, col - 1] = 'B';
                }
            }
        }

        private static bool CoordinatesAreValid(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
