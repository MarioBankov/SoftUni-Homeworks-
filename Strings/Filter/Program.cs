using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string numbers = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {

                if (char.IsDigit(text[i]))
                {
                    numbers += text[i];
                }
                else if (char.IsLetter(text[i])) 
                {
                    letters += text[i];
                }
                else
                {
                    other += text[i];
                }
               
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
