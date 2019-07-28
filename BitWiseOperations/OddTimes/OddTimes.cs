using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int reseult = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int result1 = array[i] ^ reseult;
                if (result1==array[i])
                {
                    reseult = array[i];
                }
            }
        }
    }
}
