using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if ( type =="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int max =  GetMax(a, b);

                

            }
            else if (type=="char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
               char max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if (type=="string")
            {
               string a = Console.ReadLine();
               string b = Console.ReadLine();
                string max = GetMax(a,b);
                Console.WriteLine(max);
            }
         
        }
       
        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
        static char GetMax(char a, char b)
        {
            int grater = Math.Max(a, b);
            return (char)grater;
        }
        static string GetMax(string a, string b)
        {
            string theLongest = string.Empty;
            int compare = string.Compare(a, b);
            if (compare<0)
            {
                theLongest = b;
            }
            else
            {
                theLongest = a;
            }

            return theLongest;
        }

    }
}
