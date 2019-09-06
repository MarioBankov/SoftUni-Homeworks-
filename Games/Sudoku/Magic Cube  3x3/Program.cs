using System;
using System.Linq;

namespace Magic_Cube__3x3
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] elements = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           int[] variation = new int[elements.Length];
           bool[] used = new bool[elements.Length];
            Gen(elements,variation,used,0);
        }

        private static void Gen(int[] elements, int[] variation, bool[] used, int index)
        {
            if (index >=variation.Length)
            {
                
                if (CheckIfAllSidesAre15(variation))
                {
                    Print(variation);
                    Console.WriteLine();
                }
                return;
            }
            else
            {
                for (int i = 0; i < used.Length; i++)
                {
                    if (used[i] == false)  // if the element is not used 
                    { 
                        used[i] = true;   //  set element as used;
                        variation[index] = elements[i];   //1,2,3,4,5,6,8,,9
                        Gen(elements, variation, used, index + 1);
                        used[i] = false;
                    }
                }
            }
        }

        private static void Print(int[] variation)
        {
            Console.WriteLine("{0} {1} {2}",variation[0],variation[1],variation[2]);
            Console.WriteLine("{0} {1} {2}",variation[3],variation[4],variation[5]);
            Console.WriteLine("{0} {1} {2}",variation[6],variation[7],variation[8]);
        }

        private static bool CheckIfAllSidesAre15(int[] variation)
        {

            if (variation[0]+variation[1]+variation[2]==15&&
                variation[3] + variation[4] + variation[5] == 15 &&
                variation[6] + variation[7] + variation[8] == 15 &&
                variation[0] + variation[3] + variation[6] == 15 &&
                variation[1] + variation[4] + variation[7] == 15 &&
                variation[2] + variation[5] + variation[8] == 15 &&
                variation[0] + variation[4] + variation[8] == 15 &&
                variation[2] + variation[4] + variation[6] == 15 )
            {
                return true;
            }
            return false;
        }
    }
}
