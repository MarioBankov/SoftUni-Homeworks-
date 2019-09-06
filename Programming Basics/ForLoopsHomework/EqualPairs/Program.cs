using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int maxDiff = 0;
            int sameValue = 0;
            for (int i = 1; i <= n; i++)
            {
                sum2 = sum1; 
                int nummber1 = int.Parse(Console.ReadLine()); 
                int number2 = int.Parse(Console.ReadLine());  
                sum1 = nummber1 + number2;  
                if (i > 1)
                {


                    if (sum1 - sum2 != 0)
                    {
                        int diff = Math.Abs(sum1 - sum2);
                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                    }
                    else
                    {
                        sameValue = sum1;
                    }
                }
            }

            if (sum1==sum2)
            {
                Console.WriteLine("Yes, value={0}", sum1);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }

        }
    }
}
