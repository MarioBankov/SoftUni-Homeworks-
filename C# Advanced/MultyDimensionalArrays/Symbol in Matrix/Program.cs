using System;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            char x = char.Parse(Console.ReadLine());
            bool notFound = false;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == x)
                    {
                        Console.WriteLine("({0}, {1})",row,col);
                        notFound = false;
                        break;
                    }
                    else
                    {
                        notFound = true;
                    }
                }
            }
            if (notFound)
            {
                Console.WriteLine("{0} does not occur in the matrix",x);
            }
        }
    }
}
