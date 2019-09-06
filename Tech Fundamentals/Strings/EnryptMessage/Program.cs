using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnryptMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string encrypt = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
               encrypt+= (char)(message[i] + 3);
            }
            Console.WriteLine(encrypt);
        }
    }
}
