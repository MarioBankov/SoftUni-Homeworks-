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
                var regex = @"(?<artis>^[A-Z]{1}[ a-z']+):([A-Z ]+)";
                Match  match  = Regex.Match(data, regex);
                if (match.Value.Length==0) // if the match do not succeed
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                // match was ssuccessful
                string encrypt = match.Value.Replace(':', '@');  
                string result = string.Empty;
                var key = match.Groups["artis"].Length;  // key  is the length of the artist
                for (int i = 0; i < encrypt.Length; i++)
                {
                 
                    if (encrypt[i]=='@')  // if the char is @ we need to keep it @ 
                    {
                        result += '@';
                        continue;
                    }
                    if (encrypt[i]==' ')
                    {
                        result += ' ';
                        continue;
                    }
                    if (encrypt[i]=='\'')
                    {
                        result += '\'';
                        continue;
                    }
                    
                    int number = (int)encrypt[i];
                    for (int j = 0; j < key; j++)   // this part is scary 
                    {
                       
                        if (char.IsLower(encrypt[i]))
                        {
                            if (number+1<=122)
                            {
                                number++;
                            }
                            else
                            {
                                number = 97;
                            }
                        }
                        else
                        {
                            if (number+1<=90)
                            {
                                number++;
                            }
                            else
                            {
                                number = 65;
                            }
                        }

                    }
                    result += (char)number;
                }
                Console.WriteLine("Successful encryption: {0}",result);
            }
           
        }
    }
}
