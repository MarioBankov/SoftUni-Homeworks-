using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "Last note")
                {
                    break;
                }
                string[] arg = data.Split(new char[] { '=', '<' }, StringSplitOptions.RemoveEmptyEntries);
                bool isnumber = int.TryParse(arg[1], out int result);
                bool incorrect = false;
                bool isNameCorrect = CheckName(arg[0]);
                if (isnumber&& isNameCorrect)
                {
                    bool iseven = arg[2].Length == int.Parse(arg[1]);
                    if (iseven)
                    {
                        int length = int.Parse(arg[1]);
                        if (length == arg[2].Length)
                        {
                            Console.WriteLine("Coordinates found! {0} -> {1}",string.Join("",arg[0].Where(x=>char.IsLetterOrDigit(x))),arg[2]);
                        }
                    }
                    else
                    {
                        incorrect = true;
                    }
                }
                else
                {
                    incorrect = true;
                }
                if (incorrect)
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }

        private static bool CheckName(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetterOrDigit(text[i]) || text[i] == '!' || text[i] == '#' || text[i] == '?' || text[i] == '@' || text[i] == '$')
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
