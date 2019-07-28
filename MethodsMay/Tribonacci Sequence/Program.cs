    using System;

    namespace Tribonacci_Sequence
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                if (n==0)
                {
                    Console.Write("0");
                }
                else if (n==1)
                {
                    Console.Write("1");
                }
                else if (n==2)
                {
                    Console.WriteLine("1 1");
                }
                else if (n==3)
                {
                    Console.Write("1 1 2");
                }
                else
                {
                    Console.Write("1 1 2 ");
                    GetFibonacci(n);
                }
            

            }

            private static void GetFibonacci(int n)
            {
                int first = 1;
                int second = 1;
                int thirt = 2;
                for (int i = 0; i <n-3; i++)
                {
                    int result = first + second + thirt;
                    Console.Write(result+" ");
                    first = second;
                    second = thirt;
                    thirt = result;
                }
            }
        }
    }
