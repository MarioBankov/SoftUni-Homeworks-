using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                int fistNum = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    int secNum = array[j];
                    if (fistNum+secNum==sum)
                    {
                        Console.WriteLine("{0} {1}",fistNum,secNum);
                    }
                }
            }
        }
    }
}
