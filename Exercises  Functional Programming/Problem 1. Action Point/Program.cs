using System;
using System.Linq;

namespace Problem_1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split()   // you can do anyting in c# , even prin in Select() :D
                .Select(x => { Console.WriteLine(x); return x; }).ToArray();


            Action<string[]> PrintNames = n => Console.WriteLine(string.Join(Environment.NewLine,n));   // norlam way  
            PrintNames(Console.ReadLine().Split());
        }
    }
}
