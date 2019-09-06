using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int specialNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    for (int k = 1; k < 9; k++)
                    {
                        for (int m = 1; m < 9; m++)
                        {

                            if (specialNumber%i == 0 && specialNumber%j == 0 && specialNumber % k== 0 &&  specialNumber%m == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ",i,j,k,m);
                            }
                        }
                    }
                }
            }
        }
    }
}
