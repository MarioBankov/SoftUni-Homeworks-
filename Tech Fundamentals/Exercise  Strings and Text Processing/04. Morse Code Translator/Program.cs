using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringToMorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] morseLetters = { " ", ".-", "-...", "-.-.",
                "-..", ".", "..-.", "--.", "....", "..", ".---",
                "-.-", ".-..", "--", "-.", "---", ".--.",
                "--.-", ".-.", "...", "-", "..-", "...-", ".--",
                "-..-", "-.--", "--..", ".----", "..---",
                "...--", "....-", ".....", "-....", "--...", "---..",
                "----.", "-----" };

            string result = string.Empty;

            string[] morse = Console.ReadLine().Split(" | ");  // [..] [-- .- -.. .]
            for (int k = 0; k < morse.Length; k++)
            {
                string[] code = morse[k].Split(); // [..] [--] [.-] [-..] [.]

                for (int i = 0; i < code.Length; i++)
                {
                    string morseLetter = code[i];
                    for (short j = 0; j < morseLetters.Length; j++)
                    {
                        if (morseLetter == morseLetters[j])
                        {
                            result += letters[j].ToString().ToUpper();
                            break;
                        }
                    }
                }
                result += " ";
            }
            Console.WriteLine(result);

        }
    }
}