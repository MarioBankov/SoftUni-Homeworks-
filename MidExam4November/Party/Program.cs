using System;

namespace Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i%15==0)
                {
                    partySize += 5;
                }
                sum += 50;
                sum -= (partySize * 2);
                if (i%3==0)
                {
                    sum -= (partySize * 3);
                }
                if (i%5==0)
                {
                    sum += (partySize * 20);
                }
                if (i % 3 == 0&& i % 5 == 0)
                {
                    sum -= (partySize * 2);
                }
            }
            Console.WriteLine("{0} companions received {1} coins each.",partySize,sum/partySize);
        }
    }
}
