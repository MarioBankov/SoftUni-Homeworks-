using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int thith = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            Console.WriteLine(((first+second)/thith)*fourth);

        }
    }
}
