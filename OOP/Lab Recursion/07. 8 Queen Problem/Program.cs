using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._8_Queen_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
           char[,] bord = new char[8, 8];
           // for (int i = 0; i < 8; i++)
           // {
           //     for (int j = 0; j < 8; j++)
           //     {
           //         bord[i, j] = '0';
            //    }
          //  }


            FindPlaceForQueen(0, bord);




        }

        private static void FindPlaceForQueen(int row, char[,] bord)
        {
            if (CountQueens(bord) == 8)
            {

                Console.WriteLine();
                Print(bord);

                Console.WriteLine(CountQueens(bord));

            }
            else
            {
                for (int j = 0; j < 8; j++)
                {
                    if (PlaceIsSafe(row, j, bord))
                    {
                        bord[row, j] = 'Q';

                        FindPlaceForQueen(row + 1, bord);
                        RemoveLastQueen(row, j, bord);
                    } 
                }

            }
        }

        private static int CountQueens(char[,] bord)
        {
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (bord[i, j] == 'Q')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static void RemoveLastQueen(int i, int j, char[,] bord)
        {
            bord[i, j] = '0';
        }

        private static void Print(char[,] bord)
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(bord[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool PlaceIsSafe(int row, int col, char[,] bord)
        {
            for (int i = 0; i < 8; i++)
            {
                if (bord[row, i] == 'Q')
                {
                    return false;
                }
                if (bord[i, col] == 'Q')
                {
                    return false;
                }
                if (row + i <= 7 && col + i <= 7)
                {
                    if (bord[row + i, col + i] == 'Q')
                    {
                        return false;
                    }
                }
                if (row - i >= 0 && col - i >= 0)
                {
                    if (bord[row - i, col - i] == 'Q')
                    {
                        return false;
                    }
                }
                if (row + i <= 7 && col - i >= 0)
                {
                    if (bord[row + i, col - i] == 'Q')
                    {
                        return false;
                    }
                }
                if (row - i >= 0 && col + i <= 7)
                {
                    if (bord[row - i, col + i] == 'Q')
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }
}
