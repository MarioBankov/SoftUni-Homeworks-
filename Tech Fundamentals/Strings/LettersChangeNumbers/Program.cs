using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int someValue;  
                string element = input[i];
                string sub = element.Substring(1, element.Length -2);
                bool sucsess = int.TryParse(sub,out someValue);
                if (sucsess==false)
                {
                    continue;
                }
                int number = int.Parse(sub);
                char first = element[0];
                char last = element[element.Length - 1];
               
                if (char.IsUpper(first))
                {
                   int placeInAplhabet =  (int)first - 64;
                    sum += number*1.00 / placeInAplhabet;
                }
                else 
                {
                    int placeInAplhabet = (int)first - 96;
                    sum += number * placeInAplhabet;
                }
                if (char.IsUpper(last))
                {
                    int placeInAplhabet = (int)last - 64;
                    sum -=  placeInAplhabet;
                }
                else
                {
                    int placeInAplhabet = (int)last - 96;
                    sum += placeInAplhabet;
                }   

                
            }
            Console.WriteLine("{0:F2}",sum);
        }
    }
}
