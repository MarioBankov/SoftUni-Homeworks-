namespace _1.First
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); //20 //10100
            int bit = int.Parse(Console.ReadLine());  //0
            List<int> binaryNumber = new List<int>();  
            while (number != 0)
            {
                int bits = 0;
                bits = number % 2;
                Console.WriteLine(bits);
                binaryNumber.Add(bits);
                number = number/ 2;
            }
           
            binaryNumber.Reverse();
            Console.WriteLine(string.Join("",binaryNumber));
            int count = 0;
            for (int i = 0; i < binaryNumber.Count; i++)
            {
                if (binaryNumber[i]==bit)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
