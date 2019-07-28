using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine().ToUpper();
            string withOutDigits = string.Empty;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {

                    continue;
                }
                withOutDigits += input[i];
               
            }
            for (int i = 0; i < input.Length; i++)
            {
                
                if (char.IsDigit(input[i]))
                {
                    StringBuilder number = new StringBuilder();
                    
                    for (int j = i; j < input.Length; j++)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            number = number.Append(input[j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    string sub = input.Substring(0, i);
                    for (int k = 0; k < int.Parse(number+""); k++)
                    {
                      result=  result.Append(sub);
                    }
                    input = input.Remove(0, i + number.Length);
                    i = 0;
                }
                
               
            }
            var uniqe = withOutDigits.Distinct<char>().ToArray();
            Console.WriteLine("Unique symbols used: "+uniqe.Length);
            
            Console.WriteLine(result);
           


            
        }
    }
}
