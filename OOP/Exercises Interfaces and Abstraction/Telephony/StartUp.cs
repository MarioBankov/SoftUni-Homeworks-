using System;

namespace Telephony
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbersToCall = Console.ReadLine().Split();
            string[] webSites = Console.ReadLine().Split();

            Phone p = new Phone("Samsung");

            foreach (var item in numbersToCall)
            {
                Console.WriteLine(p.Call(item));
            }
            foreach (var item in webSites)
            {
                Console.WriteLine(p.Browsing(item));
            }

        }
    }
}
