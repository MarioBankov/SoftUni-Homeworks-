using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
           

            for (int i = firstNumber; i <= secondNumber; i++)
            {

                int oddSum = 0;
                int evenSum = 0;

                string currentNumber = i + "";

                for (int j = 0; j <currentNumber.Length; j++)
                {
                    
                    int number = int.Parse(currentNumber[j]+"");
                    if (j%2==1)
                    {
                        oddSum += number;
                    }
                    else
                    {
                        evenSum += number;
                    }
                    

                }
                if (oddSum == evenSum)
                {
                    Console.Write(currentNumber + " ");
                }

            }
        }
    }
}
