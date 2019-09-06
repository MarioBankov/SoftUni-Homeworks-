using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                int index1 = text.IndexOf('@')+1;
                int index2 = text.IndexOf('|');
                int index3 = text.IndexOf('#')+1;
                int index4 = text.IndexOf('*');
                string name = text.Substring(index1, index2 - index1);
                string age = text.Substring(index3, index4 - index3);
                Console.WriteLine("{0} is {1} years old.",name,age);
            }
        }
    }
}
