using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string userName = Console.ReadLine();
                usernames.Add(userName);
            }
            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
