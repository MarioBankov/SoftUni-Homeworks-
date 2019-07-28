using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string data = Console.ReadLine();
            if (type == "int")
            {
                Print(int.Parse(data));
            }
            else if (type == "real")
            {
                Print(double.Parse(data));
            }
            else
            {
                Print(data);
            }
        }
        static void Print(int a )
        {
            Console.WriteLine(a*2);
        }
        static void Print(double a)
        {
            Console.WriteLine("{0:f2}",a*1.5);
        }
        static void Print( string a)
        {
            Console.WriteLine("${0}$",a);
        }
    }
}
