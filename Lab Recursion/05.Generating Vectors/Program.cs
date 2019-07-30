using System;

namespace _05.Generating_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Generate(arr, 0);
        }

        private static void Generate(int[] arr,int index)
        {
            if (index>arr.Length-1)
            {
                Console.WriteLine(string.Join(" ",arr));
                return;

            }
            for (int i = 0; i <= 1; i++)
            {
                arr[index] = i;
                Generate(arr, index + 1);
            }
        }
    }
}
