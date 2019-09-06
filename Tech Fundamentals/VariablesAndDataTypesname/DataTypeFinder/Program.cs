using System;
using System.Linq;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "END")
                {
                    break;
                }
                bool isBolean = bool.TryParse(data, out bool boolean);
                bool isInteger = int.TryParse(data, out int integer);
                bool isChar = char.TryParse(data, out char character);
                bool isDouble = double.TryParse(data, out double floating);
                if (isInteger)
                {
                    Console.WriteLine("{0} is integer type", data);
                }
                else if (isDouble)
                {
                    Console.WriteLine("{0} is floating point type", data);
                }
                else if (isBolean)
                {
                    Console.WriteLine("{0} is boolean type",data);
                }
                else if (isChar)
                {
                    Console.WriteLine("{0} is character type",data);
                }
                else
                {
                    Console.WriteLine("{0} is string type ",data);
                }

            }
        }
    }
}
