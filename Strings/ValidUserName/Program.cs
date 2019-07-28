using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidUserName
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] userNames = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> validUserNames = new List<string>();
            for (int i = 0; i < userNames.Length; i++)
            {

                if (userNames[i].Length>=3&&userNames[i].Length<=16)
                {
                    if (!userNames[i].Contains(" "))
                    {
                        if (Validate(userNames[i]))
                        {
                            validUserNames.Add(userNames[i]);
                        }
                    }
                }
            }
            foreach (var item in validUserNames)
            {
                Console.WriteLine(item);
            }
        }

        private static bool Validate(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i])||s[i]=='_'||s[i]=='-')
                {

                }
                else
                {
                    return false;
                }
               
            }
            return true;
        }
    }
}
