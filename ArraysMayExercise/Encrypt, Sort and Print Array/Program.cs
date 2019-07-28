using System;
using System.Linq;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] results = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                string text = Console.ReadLine();
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == 'a' || text[j] == 'A'
                        || text[j] == 'o' || text[j] == 'O' || text[j] == 'u' 
                        || text[j] == 'U' || text[j] == 'e' || text[j] =='E' || text[j] =='i' || text[j] =='I')
                    {
                        sum += ((int)text[j] * text.Length);
                    }
                    else
                    {
                        sum += ((int)text[j] / text.Length);
                    }
                }
                results[i] = sum;

            }
            Array.Sort(results);
            results.Reverse();
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
           

        }
    }
}
