using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            if (rows==1)
            {
                Console.WriteLine(1);
                return;
            }
            BigInteger[][] matrix = new BigInteger[rows][];
            matrix[0] = new BigInteger[1] { 1 };
            matrix[1] = new BigInteger[2] { 1, 1 };
            for (int i = 2; i < rows; i++)
            {
                BigInteger[] arr = new BigInteger[i + 1];
                arr[0] = 1;
                arr[arr.Length - 1] = 1;
                for (int j = 0; j < matrix[i-1].Length-1; j++)
                {
                    arr[j + 1] = matrix[i - 1][j] + matrix[i - 1][j + 1];
                }
                matrix[i] = arr;
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }
        }
    }
}
