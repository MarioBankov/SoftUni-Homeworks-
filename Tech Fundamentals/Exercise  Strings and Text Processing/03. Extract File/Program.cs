using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split('\\');
            string file = text.Last().Split('.').First();
            string extension = text.Last().Split('.',2).Last();
            Console.WriteLine("File name: {0}",file);
            Console.WriteLine("File extension: {0}",extension);
        }
    }
}
