using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            while (true)
            {
                string text = Console.ReadLine();
                if (text=="find")
                {
                    break;
                }
                string result = string.Empty;
                int j = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (j == keys.Length)
                    {
                        j = 0;
                    }

                    result += (char)(text[i] - keys[j]);

                    j++;
                }
                int index = result.IndexOf('&')+1;
                int index2 = result.IndexOf('&',index);
                string item = result.Substring(index, index2 - index);
                int index3 = result.IndexOf('<')+1;
                int index4 = result.IndexOf('>');
                string coordinates = result.Substring(index3, index4 - index3);
                Console.WriteLine("Found {0} at {1}",item,coordinates);
            }
        }
    }
}
