using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            var regex = @"[A-Za-z0-9]{16,25}";
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, regex);
            foreach (Match item in matches)
            {
                string result = string.Empty;
                if (item.Length == 16)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (i % 4 == 0 && i != 0)
                        {
                            result += '-';
                           
                        }
                        if (char.IsLower(item.Value[i]))
                        {
                            result += char.ToUpper(item.Value[i]);
                        }
                        else if (char.IsDigit(item.Value[i]))
                        {
                            result += (9 - int.Parse(item.Value[i].ToString())).ToString();
                        }
                        else
                        {
                            result += item.Value[i];
                        }
                    }

                }
                else if (item.Value.Length == 25)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (i % 5 == 0 && i != 0)
                        {
                            result += '-';
                            
                        }
                        if (char.IsLower(item.Value[i]))
                        {
                            result += char.ToUpper(item.Value[i]);
                        }
                        else if (char.IsDigit(item.Value[i]))
                        {
                            result += (9 - int.Parse(item.Value[i].ToString())).ToString();
                        }
                        else
                        {
                            result += item.Value[i];
                        }
                    }
                }
                list.Add(result);
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
