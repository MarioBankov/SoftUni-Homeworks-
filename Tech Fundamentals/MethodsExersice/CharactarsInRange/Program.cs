using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactarsInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            PrintCharsBretweenTwoChars(a, b);
        }
        static public void PrintCharsBretweenTwoChars(char a, char b)
        {
            if (a < b)
            {



                for (int i = a + 1; i < b; i++)  //67 //35
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {


                for (int i = b + 1; i < a; i++)
                {
                    Console.Write((char)i + " ");
                }

            }

        }

    }
}
