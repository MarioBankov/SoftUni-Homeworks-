using System;


namespace EqualSumLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            for (int i = a; i <= b; i++)
            {
                string number = i + "";

                int first = int.Parse(number[0]+"");
                int second = int.Parse(number[1] + "");
                int thirh = int.Parse(number[2] + "");
                int fourth = int.Parse(number[3] + "");
                int fifth = int.Parse(number[4] + "");
                int firstCouple = first + second;
                int secondCouple = fourth + fifth;


                if (firstCouple > secondCouple)
                {
                    secondCouple = secondCouple + thirh;
                }
                else if (firstCouple < secondCouple)
                {
                    firstCouple = firstCouple + thirh;
                }
                if (firstCouple == secondCouple)
                {
                    Console.Write(number+" ");
                }


            }

        }
    }
}
