using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int col = 1; col <= n; col++)
            {
                
                for (int j = 0; j < col; j++)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
