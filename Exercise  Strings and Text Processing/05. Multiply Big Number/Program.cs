using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart('0');
            int second = int.Parse(Console.ReadLine());
            string s = string.Empty;
            int remainder = 0;
            for (int i = 0; i < first.Length; i++)
            {
                int digit = int.Parse(first[first.Length - 1 - i].ToString());
                int result = (digit * second)+ remainder;   
                remainder = 0;
                if (i==first.Length-1&&result>9)
                {
                    s += result%10;
                    s += result / 10;
                    break;
                }
                if (result<10)
                {
                    s += result.ToString();
                }
                else
                {
                    s += (result % 10).ToString();
                    remainder = result / 10;

                }

            }

            if ( second==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                var a = s.Reverse();

                Console.WriteLine(string.Join("", a));
            }
            


        }
    }
}
