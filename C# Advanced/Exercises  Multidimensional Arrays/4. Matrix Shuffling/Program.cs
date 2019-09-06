using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[][] matrix = new string[size.First()][];
            for (int i = 0; i < size.First(); i++)
            {
                matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="END")
                {
                    break;
                }
                string[] commands = data.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (commands.Length==5&&commands[0]=="swap")
                {
                    int r = int.Parse(commands[1]);
                    int c = int.Parse(commands[2]);
                    int r1 = int.Parse(commands[3]);
                    int c1 = int.Parse(commands[4]);
                    if (r>=0&&r<matrix.GetLength(0)&&c>=0&&c<matrix[r].Length&& r1 >= 0 && r1 < matrix.GetLength(0) && c1 >= 0 && c1 < matrix[r].Length)
                    {
                        string temp = matrix[r][c];
                        matrix[r][c] = matrix[r1][c1];
                        matrix[r1][c1] = temp;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            Console.WriteLine(string.Join(" ", matrix[i]));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
           
        }
    }
}
