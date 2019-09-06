using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = inputArr.Length;
            while (count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    inputArr[i] = inputArr[i] + inputArr[i + 1];
                    Console.Write("{0}{1}", inputArr[i], i == count - 2 ? string.Empty : " ");
                }

                Console.WriteLine();
                count--;
            }


        }
    }
}
