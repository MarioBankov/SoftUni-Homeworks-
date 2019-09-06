using System;

namespace Ferrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();
            var f = new Ferrary(driverName);
            Console.WriteLine(f);
        }
    }
}
