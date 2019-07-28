
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWord = Console.ReadLine().Split(new [] { ',',' '},StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < banWord.Length; i++)
            {
                if (text.Contains(banWord[i]))
                {
                   string replacement = new string('*', banWord[i].Length);
                     text = text.Replace(banWord[i], replacement);
                }
            }
            Console.WriteLine( text);
        }
    }
}
