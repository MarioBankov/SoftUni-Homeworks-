using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string number = Console.ReadLine();
                if (number=="END")
                {
                    break;
                }

                if (IsItPalindropme(number)==true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            
        }
        static bool IsItPalindropme(string text)
        {
            bool isTrue = false;
            if (text.Length / 2 == 0)
            {
                isTrue = true;
            }
            int[] toNumber = new int[text.Length-1];
            for (int i = 0; i < text.Length-1; i++)
            {
                toNumber[i] = int.Parse(text[i] +"");
            }
            for (int i = 0; i < text.Length/2; i++)
            {
                
              if ( text[i] == text[text.Length - 1-i])
                {
                    isTrue = true;
                }
            }
            return isTrue;

        }
    }
}
