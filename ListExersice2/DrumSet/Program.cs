using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> CopyDrumSet = new List<int>();
            for (int i = 0; i < drumSet.Count; i++)
            {
                CopyDrumSet.Add(drumSet[i]);
            }


            while (true)
            {
                
                string input = Console.ReadLine();
                if (input== "Hit it again, Gabsy!")
                {
                    break;
                }
               
                int power = int.Parse(input);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= power;
                    if (drumSet[i]<=0)
                    {
                        if (money>=CopyDrumSet[i]*3)
                        {
                            drumSet[i] = CopyDrumSet[i];
                            money -= CopyDrumSet[i] * 3;
                        }
                        else
                        {
                           drumSet.RemoveAt(i);
                            CopyDrumSet.RemoveAt(i);
                            i--;
                        }
                        
                    }
                    
                }
            }
            Console.WriteLine(string.Join(" ",drumSet));
            Console.WriteLine("Gabsy has {0:f2}lv.",money);
        }
    }
}
