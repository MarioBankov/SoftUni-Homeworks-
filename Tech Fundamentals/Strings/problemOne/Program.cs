using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                char[] array = new char[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    array[array.Length - 1 - i] = input[i];
                }
                Console.WriteLine("{0}={1}",input,string.Join("",array));
            }
        }
    }
}
