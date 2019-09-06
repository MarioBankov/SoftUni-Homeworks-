using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            List<char> array = new List<char>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i]!=' ')
                {
                    array.Add(words[i]);
                }
               
            }
              
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine("{0}.{1}",i+1,array[i]);
            }

            
        }
    }
}
