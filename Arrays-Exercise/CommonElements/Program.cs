using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();
            for (int i = 0; i < array2.Length; i++)
            {
                string secondElement = array2[i];
                for (int j = 0; j < array1.Length; j++)
                {
                    string element = array1[j];
                    if (secondElement==element)
                    {
                        Console.Write(element+" ");
                       
                    }
                }
            }
        }
    }
}
