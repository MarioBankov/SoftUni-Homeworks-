using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double sideBar = double.Parse(Console.ReadLine());

            double area = lenght * width;
            double bar = sideBar *sideBar;
            double dancing = area * 0.19;
            double freeSpace = area - (bar + dancing);
            double numberOfGuest = ( freeSpace / 3.2);
            double number = Math.Ceiling(numberOfGuest);

            Console.WriteLine(number);
        }
    }
}
