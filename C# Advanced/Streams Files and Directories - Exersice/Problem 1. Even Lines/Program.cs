using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Problem_1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            char symbol = '@';
            using (var reader =new StreamReader(path))
            {
                string line = reader.ReadLine();
                int lineCounter = 0;
                while (line!=null)
                {
                    if (lineCounter%2==0)
                    {
                        line = ReplacePuncWithSpecialSymbol(line, symbol);
                        var rversedLine = line.Split().Reverse();
                        Console.WriteLine(string.Join(" ",rversedLine));
                    }
                    line = reader.ReadLine();
                    lineCounter++;
                }
            }
        }

        private static string ReplacePuncWithSpecialSymbol(string line, char symbol)
        {
           return line.Replace('.', symbol).Replace(',', symbol).Replace('-', symbol).Replace('!', symbol).Replace('?', symbol);
        }
    }
}
