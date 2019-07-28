using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[]train= new int [n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }
            foreach (var item in train)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }

    }
}
