using System;

namespace Helen_s_Abduction
{
    class Program
    {
        static char[][] field = null;
        static int playerRow;
        static int playerCol;
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            field = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                field[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'P')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }
            field[playerRow][playerCol] = '-';
            bool win = false;
            while (energy > 0)
            {
                string[] command = Console.ReadLine().Split();
                string direction = command[0];
                int spawnRow = int.Parse(command[1]);
                int spawnCol = int.Parse(command[2]);

                SpawnEnemy(spawnRow, spawnCol);
                field[playerRow][playerCol] = '-';
                MovePlayer(direction);
                

                energy--;
                if (field[playerRow][playerCol] == 'S')
                {
                    energy -= 2;
                    field[playerRow][playerCol] = 'P';
                }
                else if (field[playerRow][playerCol] == 'H')
                {
                    field[playerRow][playerCol] = '-';
                    win = true;
                    break;
                }
                else if (field[playerRow][playerCol]=='-')
                {
                    field[playerRow][playerCol] = 'P';
                }
                if (energy<=0)
                {
                    field[playerRow][playerCol] = 'X';
                    break;
                }

                
            }

            if (win)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");

            }
            else
            {
                Console.WriteLine($"Paris died at {playerRow};{playerCol}.");
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join("", field[i]));
            }
        }

        private static void MovePlayer(string direction)
        {
            if (direction == "up")
            {
                if (playerRow - 1 >= 0)
                {
                    playerRow--;
                }
            }
            else if (direction == "down")
            {
                if (playerRow + 1 < field.Length)
                {
                    playerRow++;
                }
            }
            else if (direction == "right")
            {
                if (playerCol + 1 < field[playerRow].Length)
                {
                    playerCol++;
                }
            }
            else if (direction == "left")
            {
                if (playerCol - 1 >= 0)
                {
                    playerCol--;
                }
            }
        }

        private static void SpawnEnemy(int x, int y)
        {
            field[x][y] = 'S';
        }


    }
}
