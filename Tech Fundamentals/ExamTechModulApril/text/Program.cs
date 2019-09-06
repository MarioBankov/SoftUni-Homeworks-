using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "tackle: the equipment required for a task or sport | code: write code for a computer program | bit: a small piece, part, or quantity of something | tackle: make determined efforts to deal with a problem | bit: a short time or distance";

            string[] split = Regex.Split(text, @"\| ");

            for (int i = 0; i < split.Length; i++)
            {
                string[] split1 = Regex.Split(split[i], @"\:");
                foreach (var item in split1)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
