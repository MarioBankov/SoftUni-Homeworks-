using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;

            for (int i = 0; i < username.Length; i++)
            {
                pass += username[username.Length - 1 - i];
            }
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == pass)
                {
                    Console.WriteLine("User {0} logged in.", username);
                    break;
                }

                if (count == 3)
                {
                    Console.WriteLine("User {0} blocked!",username);
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                count++;



            }


        }
    }
}
