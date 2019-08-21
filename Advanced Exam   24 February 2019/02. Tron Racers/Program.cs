using System;

namespace _02._Tron_Racers
{
    class Program
    {
        static char[,] field;
        static int[] coordinatesPlayerOne;
        static int[] coordinatesPlayerTwo;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char player1 = 'f';
            char player2 = 's';
             field = new char[size, size];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = data[j];
                }
            }
            

            coordinatesPlayerOne = FindPlayer(field, player1);
            coordinatesPlayerTwo = FindPlayer(field, player2);
           
            while (true)
            {
                string[] moves = Console.ReadLine().Split();
                string firstPlayerDirection = moves[0];
                string secondPlayerDirection = moves[1];

                if (firstPlayerDirection=="up")
                {
                    coordinatesPlayerOne[0]--;
                    if (coordinatesPlayerOne[0]<0)
                    {
                        coordinatesPlayerOne[0] = field.GetLength(0) - 1;
                    }
                }
                else if (firstPlayerDirection=="down")
                {
                    coordinatesPlayerOne[0]++;
                    if (coordinatesPlayerOne[0] ==field.GetLength(0))
                    {
                        coordinatesPlayerOne[0] = 0;
                    }
                }
                else if (firstPlayerDirection=="left")
                {
                    coordinatesPlayerOne[1]--;
                    if (coordinatesPlayerOne[1]<0)
                    {
                        coordinatesPlayerOne[1] = size - 1;
                    }
                }
                else if (firstPlayerDirection=="right")
                {
                    coordinatesPlayerOne[1]++;
                    if (coordinatesPlayerOne[1] == size)
                    {
                        coordinatesPlayerOne[1] =0;
                    }
                }
                if (field[coordinatesPlayerOne[0],coordinatesPlayerOne[1]]=='s')
                {
                    field[coordinatesPlayerOne[0], coordinatesPlayerOne[1]] = 'x';
                    Print();
                    break;
                }
                else
                {
                    field[coordinatesPlayerOne[0], coordinatesPlayerOne[1]] = 'f';
                }
                if (secondPlayerDirection=="up")
                {
                    coordinatesPlayerTwo[0]--;
                    if (coordinatesPlayerTwo[0]<0)
                    {
                        coordinatesPlayerTwo[0] = size - 1;
                    }
                }
                else if (secondPlayerDirection=="down")
                {
                    coordinatesPlayerTwo[0]++;
                    if (coordinatesPlayerTwo[0] == size)
                    {
                        coordinatesPlayerTwo[0] = 0;
                    }
                }
                else if (secondPlayerDirection=="left")
                {
                    coordinatesPlayerTwo[1]--;
                    if (coordinatesPlayerTwo[1]<0)
                    {
                        coordinatesPlayerTwo[1] = size - 1;
                    }
                }
                else if (secondPlayerDirection=="right")
                {
                    coordinatesPlayerTwo[1]++;
                    if (coordinatesPlayerTwo[1] == size)
                    {
                        coordinatesPlayerTwo[1] = 0;
                    }

                }
                if (field[coordinatesPlayerTwo[0],coordinatesPlayerTwo[1]]=='f')
                {
                    field[coordinatesPlayerTwo[0], coordinatesPlayerTwo[1]] = 'x';
                    Print();
                    break;
                }
                else
                {
                    field[coordinatesPlayerTwo[0], coordinatesPlayerTwo[1]] = 's';
                }
                
                
            }


        }

        private static void Print()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }
        }

        private static int[] FindPlayer(char[,] field, char player)
        {
            int[] result = new int[2];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i,j]==player)
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
