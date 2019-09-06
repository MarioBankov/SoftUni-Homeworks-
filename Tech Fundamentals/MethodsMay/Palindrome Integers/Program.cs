using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                string number = Console.ReadLine();
                if ( number=="END")
                {
                    break;
                }

                string mirrorNumber = MirrorImage(number);
                PrintResult(mirrorNumber,number);
                
            }


        }

      public static void PrintResult(string a,string b)
        {
            if (a == b)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static string MirrorImage(string command)
        {
            string result = string.Empty;

            for (int i = 0; i < command.Length; i++)
            {
               result += command[command.Length - 1 - i];
            }
            return result;

        }
    }
}

