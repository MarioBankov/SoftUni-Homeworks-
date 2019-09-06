using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReveseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();
            string[] reversd = new string[texts.Length];
            for (int i = 0; i < texts.Length; i++)
            {
                reversd[i] = texts[texts.Length - 1 - i];
            }
            foreach (var item in reversd)
            {
                Console.Write(item+" ");
            }
        }
    }
}
