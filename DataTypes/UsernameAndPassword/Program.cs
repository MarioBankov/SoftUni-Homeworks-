using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsernameAndPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;
            // acer =4
            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i];
            }
            int wrongAttempts = 4;
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input==pass)
                {
                    Console.WriteLine("{0} logged in.",username);
                }
               
                else
                {
                    Console.WriteLine("wrong password you have {0} attempts.", wrongAttempts-1);
                    wrongAttempts--;
                }
                if (wrongAttempts == 0)
                {
                    Console.WriteLine(" {0} is  blocked!", username);
                    Console.WriteLine("Reason : too many attempts");
                    break;
                }
            }

        }
    }
}
