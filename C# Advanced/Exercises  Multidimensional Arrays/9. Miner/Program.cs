using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            char[,] matrix = new char[size, size];
            int totalCoal = 0;
            for (int i = 0; i < size; i++)
            {
                char[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = data[j];
                    if (data[j]=='c')
                    {
                        totalCoal++;
                    }
                }
            }
            
            int collectedCoal = 0;
            int[] miner = FindMinerCoordinates(matrix);
            int row = miner[0];
            int col = miner[1];
            bool gameOver = false;
            bool allCollecet = false;
            bool noMoreCommands = true;
            for (int i = 0; i < commands.Length; i++)
            {
                string direction = commands[i];
                if (direction == "up")
                {
                    if (CheckCordinates(matrix, row - 1, col) && matrix[row - 1, col] != 'e')
                    {
                        if (matrix[row - 1, col] == 'c')
                        {
                            matrix[row - 1, col] = '*';
                            collectedCoal++;
                            
                        }
                        row = row - 1;
                        if (collectedCoal == totalCoal)
                        {
                            allCollecet = true;
                            noMoreCommands = false;
                            break;
                        }

                    }
                    else if (CheckCordinates(matrix, row - 1, col) && matrix[row - 1, col] == 'e')
                    {
                        row = row - 1;
                        gameOver = true;
                        noMoreCommands = false;
                        break;
                    }
                }
                else if (direction == "down")
                {
                    if (CheckCordinates(matrix, row + 1, col) && matrix[row + 1, col] != 'e')
                    {
                        if (matrix[row + 1, col] == 'c')
                        {
                            collectedCoal++;
                            matrix[row + 1, col] = '*';
                        }
                        row = row + 1;
                        if (collectedCoal == totalCoal)
                        {
                            allCollecet = true;
                            noMoreCommands = false;
                            break;
                        }
                    }
                    else if (CheckCordinates(matrix, row + 1, col) && matrix[row + 1, col] == 'e')
                    {
                        row = row + 1;
                        gameOver = true;
                        noMoreCommands = false;
                        break;
                    }
                }
                else if (direction == "left")
                {
                    if (CheckCordinates(matrix, row, col - 1) && matrix[row, col - 1] != 'e')
                    {
                        if (matrix[row, col - 1] == 'c')
                        {
                            collectedCoal++;
                           
                            matrix[row, col - 1] = '*';
                        }
                        col = col - 1;
                        if (collectedCoal == totalCoal)
                        {
                            allCollecet = true;
                            noMoreCommands = false;
                            break;
                        }
                    }
                    else if (CheckCordinates(matrix, row, col - 1) && matrix[row, col - 1] == 'e')
                    {
                        col = col - 1;
                        noMoreCommands = false;
                        gameOver = true;
                        break;
                    }
                }
                else if (direction == "right")
                {
                    if (CheckCordinates(matrix, row, col + 1) && matrix[row, col + 1] != 'e')
                    {
                        if (matrix[row, col + 1] == 'c')
                        {
                            collectedCoal++;
                            matrix[row, col + 1] = '*';
                        }
                        col = col + 1;
                        if (collectedCoal == totalCoal)
                        {
                            allCollecet = true;
                            noMoreCommands = false;
                            break;
                        }
                    }
                    else if (CheckCordinates(matrix, row, col + 1) && matrix[row, col + 1] == 'e')
                    {
                        col = col + 1;
                        gameOver = true;
                        noMoreCommands = false ;
                        break;
                    }
                }
            }
            if (noMoreCommands)
            {
                Console.WriteLine("{0} coals left. ({1}, {2})", totalCoal - collectedCoal, row, col);
            }
            if (allCollecet)
            {
                Console.WriteLine("You collected all coals! ({0}, {1})", row, col );
            }
            if (gameOver)
            {
                Console.WriteLine("Game over! ({0}, {1})", row, col );
            }
            
        }

        private static bool CheckCordinates(char[,] matrix, int row, int col)
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

        private static int[] FindMinerCoordinates(char[,] matrix)
        {
            int[] result = new int[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 's')
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
    }
}
