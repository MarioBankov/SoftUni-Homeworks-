using System;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (text?.ToLower()=="end")
                {
                    break;
                }
               var reversed = text.Reverse();
                Console.WriteLine("{0} = {1}",text,string.Join("",reversed));
            }
        }
    }
}
