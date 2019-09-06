using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().Trim('0');
            int multyply = int.Parse(Console.ReadLine());
            string result = string.Empty;
            int remeinder = 0;
            for (int i = 0; i < number.Length; i++)  
            {
                int lastNumber = int.Parse(number[number.Length - 1-i] + " ");

                int result1 = lastNumber * multyply+remeinder;
               
                    result += result1 % 10;
                
                    remeinder = result1 / 10;
               
                if (i==number.Length-1&& remeinder>0)
                {
                    result += remeinder;
                }

            }
            char[] final = result.Reverse().ToArray();
            Console.WriteLine(string.Join("",final));
            
        }
    }
}
