using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string data = Console.ReadLine();
                if (data.ToLower() =="end")
                {
                    break;
                }
                string regex = @"^(?<artis>[A-Z][a-z' ]+):(?<song>[A-Z ]+)$";
                var match = Regex.Match(data, regex);
                if (match.Success)
                {
                    var key = match.Groups["artis"].Value.Count();
                    var result = string.Empty;
                    for (int i = 0; i < match.Value.Length; i++)
                    {
                        char currentChar = match.Value[i];
                        if (currentChar==':')
                        {
                            result += '@';
                            continue;
                        }
                        if (currentChar==' ')
                        {
                            result += ' ';
                            continue;
                        }
                        if (currentChar=='\'')
                        {
                            result += '\'';
                            continue;
                        }
                        if (char.IsLower(currentChar))
                        {
                            for (int j = 0; j < key; j++)
                            {
                                if (currentChar+1<=122)
                                {
                                    currentChar++;
                                }
                                else
                                {
                                    currentChar = 'a';
                                }
                            }
                        }
                        else
                        {
                            for (int j = 0; j < key; j++)
                            {
                                if (currentChar+1<=90)
                                {
                                    currentChar++;
                                }
                                else
                                {
                                    currentChar = 'A';
                                }
                            }
                        }
                        result += currentChar;
                    }
                    Console.WriteLine("Successful encryption: {0}",result);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
