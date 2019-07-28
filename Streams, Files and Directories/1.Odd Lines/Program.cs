using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            string pathInput = @"C:\Users\Asus\source\repos\Streams, Files and Directories\1.Odd Lines\input.txt.txt";
            string pathWords = @"C:\Users\Asus\source\repos\Streams, Files and Directories\1.Odd Lines\words.txt";

            var reader1 = new StreamReader(pathWords);
            string result = string.Empty;
            using (reader1)
            {

                string line1 = reader1.ReadLine();

                var reader = new StreamReader(pathInput);
                using (reader)
                {
                    var line2 = reader.ReadLine();
                    while (line1!=null&&line2!=null)
                    {
                        result += line2;
                        result += line1;
                        line2 = reader.ReadLine();
                        line1 = reader1.ReadLine();
                    }
                    
                }
               

            }
            var writer = new StreamWriter("output.txt");
            using (writer)
            {
                foreach (var item in result)
                {
                    writer.WriteLine(item);
                }

            }
        }
    }
}


