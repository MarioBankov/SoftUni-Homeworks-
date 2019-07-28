using System;
using System.Collections.Generic;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            }
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "END")
                {
                    break;
                }
                string[] commands = data.Split();
                string command = commands[0].ToLower();
                if (command == "add")
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);
                    int number = int.Parse(commands[3]);



                    if (row > -1 && row < rows && col > -1 && col < matrix[row].Length)
                    {
                        matrix[row][col] += number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                else
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);
                    int number = int.Parse(commands[3]);
                    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
