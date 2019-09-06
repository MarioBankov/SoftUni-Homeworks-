using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a possitive Integer ");
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] array = new int[sizeOfArray];

            Console.WriteLine("Enter  the values of the array :");
            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }

            bool symmetttrick = true;
            for (int i = 0; i < array.Length / 2; i++)  // 1,2,3,3,2,1 
            {
                if (array[i]!=array.Length-1-i)
                {
                    symmetttrick = false;
                }
            }
            Console.WriteLine("Is Symmetrick? {0}",symmetttrick);
        }
    }
}
