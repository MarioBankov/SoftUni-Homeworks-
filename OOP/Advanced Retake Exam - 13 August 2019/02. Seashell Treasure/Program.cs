using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seashell_Treasure
{
    class Program
    {
        static char[][] field;
        static int row;
        static int col;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            field = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                char[] data = Console.ReadLine().Trim().ToCharArray().Where(x => x != ' ').ToArray();
                field[i] = data;
            }
            List<char> Collected = new List<char>();
            int stollen = 0;
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Sunset")
                {
                    break;
                }
                if (command[0] == "Collect")
                {
                    row = int.Parse(command[1]);
                    col = int.Parse(command[2]);
                    if (row >= 0 && row < rows && col >= 0 && col < field[row].Length)
                    {
                        if (CanCollect())
                        {
                            Collected.Add(field[row][col]);
                            field[row][col] = '-';
                        }

                    }
                }
                else if (command[0] == "Steal")
                {
                    row = int.Parse(command[1]);
                    col = int.Parse(command[2]);
                    string direction = command[3];

                    if (row >= 0 && row < rows && col >= 0 && col < field[row].Length)
                    {
                        if (CanCollect())
                        {
                            stollen++;
                            field[row][col] = '-';
                        }

                    }
                    else
                    {
                        continue;
                    }

                    if (direction == "up")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            row--;
                            if (row >= 0 && row < rows && col >= 0 && col < field[row].Length)
                            {
                                if (CanCollect())
                                {
                                    stollen++;
                                    field[row][col] = '-';
                                }

                            }

                        }
                    }
                    else if (direction == "down")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            row++;
                            if (row >= 0 && row < rows && col >= 0 && col < field[row].Length)
                            {
                                if (CanCollect())
                                {
                                    stollen++;
                                    field[row][col] = '-';
                                }

                            }

                        }

                    }
                    else if (direction == "left")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            col--;
                            if (row >= 0 && row < rows && col >= 0 && col < field[row].Length)
                            {
                                if (CanCollect())
                                {
                                    stollen++;
                                    field[row][col] = '-';
                                }

                            }

                        }

                    }
                    else if (direction == "rigth")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            col++;
                            if (row >= 0 && row < rows && col >= 0 && col < field[row].Length)
                            {
                                if (CanCollect())
                                {
                                    stollen++;
                                    field[row][col] = '-';
                                }

                            }

                        }

                    }
                }

            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", field[i]));
            }


            if (Collected.Count == 0)
            {
                Console.WriteLine($"Collected seashells: 0");
            }
            else
            {
                Console.WriteLine($"Collected seashells: {Collected.Count} -> {string.Join(", ", Collected)}");
            }

            Console.WriteLine("Stolen seashells: {0}", stollen);

        }

        private static bool CanCollect()
        {
            if (field[row][col] != '-')
            {
                return true;
            }
            return false;
        }
    }
}
