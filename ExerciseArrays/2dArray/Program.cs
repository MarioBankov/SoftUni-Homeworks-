using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of Rows = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write( "Enter number of Cols = ");
            int cols = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, cols];
         
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("matrix[ {0} , {1} ]  = ",row,col);
                    array[row, col] = int.Parse(Console.ReadLine());
                    
                }
               
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write(array[i,k]);
                }
                Console.WriteLine();
            }


        }
    }
}
