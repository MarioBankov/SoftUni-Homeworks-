using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;

            for (int row= 0; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    if (col == 0 || row == 0)
                    {
                        number = 1;
                    }
                    else if (col==row)
                    {
                        number = 1;
                    }
                    else
                    {
                        number = col+row;
                    }
                    Console.Write(number);
                }
                Console.WriteLine();
                
            }
        }
    }
}
