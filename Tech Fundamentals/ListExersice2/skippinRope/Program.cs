
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
                    numberList.Add(int.Parse(encryptedMessage[i] + ""));
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
            string restult = string.Empty;
            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i];
                int skip = skipList[i];
                for (int j = 0; j < take; j++)
                {
                    restult += charList[j];
                   
                }
                charList.RemoveRange(0, take);

                if (charList.Count==0)
                {
                    break;
                }
                for (int k = 0; k < skip; k++)
                {
                    charList.RemoveAt(0);
                }
            }

            Console.WriteLine(restult);
        }
    }
}