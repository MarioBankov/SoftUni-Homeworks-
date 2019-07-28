using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] zero = new char[] { '_', '_', '_' };
            ;
            char[] first = new char[] { '_', '_', '_' };

            char[] second = new char[] { '_', '_', '_' };
            int counter = 0;
            string winner = string.Empty;
            char symbol = ' ';

            while (winner == string.Empty)
            {
                DrawFild(zero, first, second);
                // * player one 
                // x player two
                symbol = TurnChecker(counter, symbol);

                Console.WriteLine("First Rows then Colums");
                List<int> cordinates = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                if (cordinates.Count!=2)
                {
                    Console.WriteLine("please insert 2 integer numbers for coordinates");
                    continue;
                }
                int x = cordinates[0];
                int y = cordinates[1];

                if (CordinatesChecker(x, y) == true)
                {
                    if (y == 0)
                    {
                        if (zero[x] == '_')
                        {
                            zero[x] = symbol;
                        }
                        else
                        {
                            Console.WriteLine(" |||||||||||||||||INVALID COORDINATES|||||||||||||||||||");
                            Console.WriteLine();
                            Console.WriteLine();
                            counter--;
                        }
                    }
                    else if (y == 1)
                    {
                        if (first[x] == '_')
                        {
                            first[x] = symbol;
                        }
                        else
                        {
                            Console.WriteLine(" |||||||||||||||||INVALID COORDINATES|||||||||||||||||||");
                            Console.WriteLine();
                            Console.WriteLine();
                            counter--;

                        }
                    }
                    else if (y == 2)
                    {
                        if (second[x] == '_')
                        {
                            second[x] = symbol;
                        }
                        else
                        {
                            Console.WriteLine(" |||||||||||||||||INVALID COORDINATES|||||||||||||||||||");
                            Console.WriteLine();
                            Console.WriteLine();
                            counter--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(" |||||||||||||||||INVALID COORDINATES|||||||||||||||||||");
                    Console.WriteLine();
                    Console.WriteLine();
                    counter--;

                }

                winner = CheckForWiner(zero, first, second);

                counter++;
            }
        }

        private static char TurnChecker(int counter, char symbol)
        {
            if (counter % 2 == 0)
            {
                Console.WriteLine();
                Console.WriteLine("\t PLAYER * TURN ");
                symbol = '*';
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("\t PLAYER O TURN ");
                symbol = 'x';
            }
            return symbol;
        }

        private static void DrawFild(char[] zero, char[] first, char[] second)
        {
            Console.WriteLine("    0  1  2");
            Console.WriteLine();
            Console.WriteLine("0-- {0}|{1}|{2}", zero[0], zero[1], zero[2]);
            Console.WriteLine("1-- {0}|{1}|{2}", first[0], first[1], first[2]);
            Console.WriteLine("2-- {0}|{1}|{2}", second[0], second[1], second[2]);
        }

        private static bool CordinatesChecker(int x, int y)
        {
            if (x >= 0 && x <= 2 && y >= 0 && y <= 2)
            {
                return true;
            }
            return false;
        }

        private static string CheckForWiner(char[] zero, char[] first, char[] second)
        {
            string winner = string.Empty;
            if (zero[0] == '*' && zero[1] == '*' && zero[2] == '*')
            {
                winner = "Player One Wins";
            }
            else if (first[0] == '*' && first[1] == '*' && first[2] == '*')
            {
                winner = "Player One Wins";
            }
            else if (second[0] == '*' && second[1] == '*' && second[2] == '*')
            {
                winner = "Player One Wins";
            }
            else if (zero[0] == '*' && first[0] == '*' && second[0] == '*')
            {
                winner = "Player One Wins";
            }
            else if (zero[1] == '*' && first[1] == '*' && second[1] == '*')
            {
                winner = "Player One Wins";
            }
            else if (zero[2] == '*' && first[2] == '*' && second[2] == '*')
            {
                winner = "Player One Wins";
            }
            else if (zero[0] == '*' && first[1] == '*' && second[2] == '*')
            {
                winner = "Player One Wins";
            }
            else if (zero[2] == '*' && first[1] == '*' && second[0] == '*')
            {
                winner = "Player One Wins";
            }
            return winner;
        }
    }
}
