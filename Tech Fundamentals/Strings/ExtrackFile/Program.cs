using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtrackFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileName = Console.ReadLine().Split('\\');
            string file = fileName[fileName.Length - 1];
            string[] tokens = file.Split('.');
            string name = tokens[0];
            string extension = tokens[1];
            Console.WriteLine("File name :"+" "+name);
            Console.WriteLine("Extension :"+" "+extension);

        }
    }
}
