using System;

namespace CostumClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new CustomStack();
            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Push(4);
            a.Push(5);
            a.Push(6);
           
            a.Foreach(Console.WriteLine);


        }
    }
}
