using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            for (int i = 0; i < usernames.Length; i++)
            {
                string user = usernames[i];
                bool correctUserName = true;
                for (int j = 0; j < user.Length; j++)
                {
                    if (char.IsLetterOrDigit(user[j]) || user[j] == '-' || user[j] == '_' )
                    {

                    }
                    else
                    {
                        correctUserName = false;
                        break;
                    }

                }
                if (correctUserName&&user.Length>=3&&user.Length<=16)
                {
                    Console.WriteLine(user);
                }

            }
        }
    }
}
