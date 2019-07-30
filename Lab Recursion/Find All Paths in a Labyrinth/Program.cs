using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_All_Paths_in_a_Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[,] board = new char[rows, cols];
            List<Char> directions = new List<Char>();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = data[j];
                }
            }

            FindPaths(0, 0, 'S',directions,board);
        }

        private static void FindPaths(int row, int col, char direction,List<char>list,char[,]board)
        {
            if (!IsInBounds(row,col,board))
            {
                return;
            }
            
            if (isExit(row,col,board))
            {
                list.Add(direction);
                if (list.Contains('S'))
                {
                    list.Remove('S');
                }
                PrintPath(list);
                list.Clear();
               
            }
            else if (!isVisited(row,col,board)&&IsFree(row,col,board))
            {
                Mark(row, col, board);
                list.Add(direction);
                FindPaths(row, col + 1, 'R',list,board);
                FindPaths(row + 1, col, 'D', list, board);
                FindPaths(row, col - 1, 'L', list, board);
                FindPaths(row - 1, col, 'U', list, board);
                Unmark(row, col, board,list);

            }
        

        }

        private static void Unmark(int row, int col, char[,] board,List<char>list)
        {
            board[row, col] = '-';
            
        }

        private static void Mark(int row, int col, char[,] board)
        {
            board[row, col] = '*';
        }

        private static bool IsFree(int row, int col, char[,] board)
        {
            if (board[row,col]=='-')
            {
                return true;
            }
            return false;
        }

        private static bool isVisited(int row, int col, char[,] board)
        {
            if (board[row,col]=='*')
            {
                return true;
            }
            return false;
        }

        private static void PrintPath(List<char> list)
        {
            Console.WriteLine(string.Join(" ",list));
        }

        private static bool isExit(int row, int col, char[,] board)
        {
            if (board[row,col]=='e')
            {
                return true;
            }
            return false;
        }

        private static bool IsInBounds(int row, int col,char[,]board)
        {
            if (row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void PrintBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
