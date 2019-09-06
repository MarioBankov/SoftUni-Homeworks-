using System;
using System.Linq;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] board = new int[9][];
            FillTheBoard(board);  // fill the bord with sudoku numbers 
            Solve(0, 0, board);

        }

        private static void Solve(int row, int col, int[][] board)
        {
            if (col == 9)
            {
                col = 0;
                row += 1;
            }
            if (row == 9)       // break the recursion.If we reach row outside of the boar.
            {
                PrintResult(board);  // Print the solve sudoku
                Console.WriteLine();
                Console.ReadLine();
                return;

            }
            for (int i = row; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (CellisFree(i, j, board))
                    {
                        for (int n = 1; n <= 9; n++)
                        {
                            if (CanPlace(i, j, board, n))   //Checks if we can place n in the free cell.
                            {
                                board[i][j] = n;
                                //PrintResult(board);
                               // Console.ReadLine();
                                Solve(i, j +1, board);
                                Remove(i, j, board);
                            }

                        }
                        return;
                    }
                }
                if (row==8)
                {
                    Console.WriteLine("Result!!!");
                    PrintResult(board);  // Print the solve sudoku
                    Console.ReadLine();
                    return;
                }
            }
        }

        private static void PrintResult(int[][] board)
        {
            
            for (int i = 0; i < 9; i++)
            {

                Console.WriteLine(string.Join(" ",board[i])); 
            }
        }

        private static bool CellisFree(int i, int j, int[][] board)
        {
            if (board[i][j] == 0)
            {
                return true;
            }
            return false;
        }

        private static bool CanPlace(int row, int col, int[][] board, int n)
        {
            
            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] == n)
                {
                    return false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] == n)
                {
                    return false;
                }
            }
            if (row <= 2 && col <= 2)
            {
                bool a = CheckSmallSquare(0, 3, 0, 3, board,n);
                return a; 
            }
            else if (row <= 2 && col >= 3 && col <= 5)
            {
                bool a =  CheckSmallSquare(0, 3, 3, 6, board,n);
                return a;
            }
            else if (row <= 2 && col >= 6 && col <= 8)
            {
                bool a = CheckSmallSquare(0, 3, 6, 9, board, n);
                return a;
            }
            else if (row >= 3 && row <= 5 && col <= 2)
            {
                bool a = CheckSmallSquare(3, 6, 0, 3, board, n);
                return a;
            }
            else if (row >= 3 && row <= 5 && col >= 3 && col <= 5)
            {
                bool a = CheckSmallSquare(3, 6, 3, 6, board, n);
                return a;
            }
            else if (row >= 3 && row <= 5 && col >= 6 && col <= 8)
            {
                bool a = CheckSmallSquare(3, 6, 6, 9, board, n);
                return a;
            }
            else if (row >= 6 && row <= 8 && col <= 2)
            {
                bool a = CheckSmallSquare(6, 9, 0, 3, board, n);
                return a;
            }
            else if (row >= 6 && row <= 8 && col >= 3 && col <= 5)
            {
                bool a = CheckSmallSquare(6, 9, 3, 6, board, n);
                return a;
            }
            else if (row >= 6 && row <= 8 && col >= 6 && col <= 8)
            {
                bool a = CheckSmallSquare(6, 9, 6, 9, board, n);
                return a;
            }

            return true;
        }

        private static bool CheckSmallSquare(int startI, int endI, int startJ, int endJ, int[][] board, int number)
        {
            for (int i = startI; i < endI; i++)
            {
                for (int j   = startJ; j < endJ; j++)
                {
                    if (board[i][j]==number)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void Remove(int i, int j, int[][] board)
        {
            board[i][j] = 0;
        }

        private static void FillTheBoard(int[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                board[i] = data;
            }
        }
    }
}
