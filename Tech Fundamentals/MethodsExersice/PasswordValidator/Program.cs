using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (IsInRange(password) && IsAlpha(password) && TwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (IsInRange(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (IsAlpha(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (TwoDigits(password)==false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


        }
        static bool IsInRange(string text)
        {
            bool correct = false;
            if (text.Length >= 6 && text.Length <= 10)
            {
                correct = true;
            }
            return correct;
        }
        static bool IsAlpha(string text)
        {
            bool result = text.All(char.IsLetterOrDigit);
            return result;
        }
        static bool TwoDigits(string text)
        {
            bool moreThanTwo = false;
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ("1234567890".Contains(text[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                moreThanTwo = true;
            }
            return moreThanTwo;
        }
    }
}
