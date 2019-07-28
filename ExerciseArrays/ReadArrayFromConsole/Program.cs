using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadArrayFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            object[] array = new object[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i]=Console.ReadLine();
            }
            
        }
    }
}
