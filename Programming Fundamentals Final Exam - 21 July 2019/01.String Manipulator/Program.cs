using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            while (true)
            {
                string data = Console.ReadLine();
                if (data.ToLower()=="end")
                {
                    break;
                }
                string[] commands = data.Split();
                string command = commands.First();
                if (command.ToLower()=="add")
                {
                    result += commands.Last();
                }
                else if (command.ToLower()=="upgrade")
                {
                    char ch = char.Parse(commands.Last());
                   result= result.Replace(ch, (char)(ch + 1));
                }
                else if (command.ToLower()=="print")
                {
                    Console.WriteLine(result);
                }
                else if (command.ToLower()=="index")
                {
                    char ch = char.Parse(commands.Last());
                    List<int> indexes = new List<int>();
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i]==ch)
                        {
                            indexes.Add(i);
                        }
                    }
                    if (indexes.Count==0)
                    {
                        Console.WriteLine("None");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ",indexes));
                    }
                }
                else if (command.ToLower()=="remove")
                {
                    string strToRemove = commands.Last();
                   result= result.Replace(strToRemove, "");
                }
            }
        }
    }
}
