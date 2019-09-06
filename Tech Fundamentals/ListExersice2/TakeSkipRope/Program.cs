
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
           string encryptedMessage = Console.ReadLine();
            var numberList = new List<int>();
            var charList = new List<char>();

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if (char.IsDigit(encryptedMessage[i]))
                {
                    numberList.Add(int.Parse(encryptedMessage[i]+""));
                }
                else
                {
                    charList.Add(encryptedMessage[i]);
                }
            }
            var takeList = new List<int>();
            var skipList = new List<int>();

            for (int index = 0; index < numberList.Count; index++)
            {
                if (index % 2 == 0)
                {
                    takeList.Add(numberList[index]);
                }
                else
                {
                    skipList.Add(numberList[index]);
                }
            }

            string result = null;

            var total = 0;
            for (int i = 0; i < skipList.Count; i++)
            {
                int skipCount = skipList[i];
                int takeCoun = takeList[i];
                result += new string(charList.Skip(total).Take(takeCoun).ToArray());
                total += skipCount + takeCoun;
            }
            Console.WriteLine(result);
        }
    }
}