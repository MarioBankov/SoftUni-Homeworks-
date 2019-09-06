using System;
using System.Linq;
using System.Numerics;


namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                string name = Console.ReadLine();
                for (int k = 0; k < name.Length; k++)
                {
                    
                    string vowels = "AEIOUaeiou";
                    if (vowels.Contains(name[k]))
                    {
                        sum += ((int)name[k] * name.Length);
                    }
                    else
                    {
                        sum+= ((int)name[k] / name.Length);
                    }
                   
                }
                result[i] = sum;
            }
            

            for (int i = 0; i < result.Length; i++)
            {
                int temp = result[i];
                for (int j = i+1; j < result.Length; j++)
                {

                    if (result[i]>result[j])
                    {
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
