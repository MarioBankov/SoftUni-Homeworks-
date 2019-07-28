using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "add me pls ";
            string[] result = text.Split();
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}
