using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSiquanceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int maxcount = 0;
            int number = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                   
                    count++;
                }
                else
                {
                    count =0;
                }
                if (count>maxcount)
                {
                    maxcount = count;
                    number = numbers[i];
                }
                
            }
            for (int i = 0; i < maxcount+1; i++)
            {
                Console.Write(number+" ");
            }

            
        }
    }
}
