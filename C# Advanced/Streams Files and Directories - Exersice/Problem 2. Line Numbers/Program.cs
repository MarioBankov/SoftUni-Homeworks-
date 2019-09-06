using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Problem_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            string path2 = "output.txt";
            string[] text = File.ReadAllLines(path);
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = $"Line {i+1}: {text[i]}";
            }
            File.WriteAllLines(path2, text);
        }
    }
}
