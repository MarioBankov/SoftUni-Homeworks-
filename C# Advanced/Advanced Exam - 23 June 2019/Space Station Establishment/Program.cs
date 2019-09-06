using System;
using System.Collections.Generic;

namespace Space_Station_Establishment
{
    class Program
    {
        static char[,] space;
        static int PlayerRow;
        static int PlayerCol;
        static int starPower = 0;
        static List<int> blackholeCoordinates=new List<int>();
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            space = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    space[i, j] = data[j];
                    if (space[i,j]=='S')
                    {
                        PlayerRow = i;
                        PlayerCol = j;
                    }
                    if (space[i, j] == 'O')
                    {
                        blackholeCoordinates.Add(i);
                        blackholeCoordinates.Add(j);
                    }
                }
            }
            bool IntoVoid = false;
            bool starpowerCollected = false;
            while (true)
            {
                string direction = Console.ReadLine();
                if (direction=="up")
                {
                    space[PlayerRow, PlayerCol] = '-';
                    PlayerRow--;
                    if (PlayerRow<0)
                    {
                        IntoVoid = true;
                        break;
                    }
                }
                else if (direction=="down")
                {
                    space[PlayerRow, PlayerCol] = '-';
                    PlayerRow++;
                    if (PlayerRow==size)
                    {
                        IntoVoid = true;
                        break;
                    }
                }
                else if (direction=="left")
                {
                    space[PlayerRow, PlayerCol] = '-';
                    PlayerCol--;
                    if (PlayerCol<0)
                    {
                        IntoVoid = true;
                        break;
                    }
                }
                else if (direction=="right")
                {
                    space[PlayerRow, PlayerCol] = '-';
                    PlayerCol++;
                    if (PlayerCol==size)
                    {
                        IntoVoid = true;
                        break;
                    }
                }
                if (space[PlayerRow,PlayerCol]=='O')
                {
                    space[PlayerRow, PlayerCol] = '-';
                    blackholeCoordinates.Remove(PlayerCol);   
                    blackholeCoordinates.Remove(PlayerRow);
                    PlayerRow = blackholeCoordinates[0];
                    PlayerCol = blackholeCoordinates[1];
                    space[PlayerRow, PlayerCol] = 'S';
                }
                else if (space[PlayerRow, PlayerCol] == '-')
                {
                    space[PlayerRow, PlayerCol] = 'S';
                }
                else
                {
                    starPower += int.Parse(space[PlayerRow, PlayerCol]+"");
                    space[PlayerRow, PlayerCol] = 'S';
                    if (starPower>=50)
                    {
                        starpowerCollected = true;
                        break;
                    }
                    
                }
            }

            if (IntoVoid)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
                Console.WriteLine("Star power collected: {0}",starPower);
                Print();
            }
            if (starpowerCollected)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                Console.WriteLine("Star power collected: {0}", starPower);
                Print();
            }
        }

        private static void Print()
        {
            for (int i = 0; i < space.GetLength(0); i++)
            {
                for (int j = 0; j < space.GetLength(1); j++)
                {
                    Console.Write(space[i,j]);
                }
                Console.WriteLine();

            }
        }
    }
}
