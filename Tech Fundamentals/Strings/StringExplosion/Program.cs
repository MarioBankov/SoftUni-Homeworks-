using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line = Console.ReadLine();

            int power = 0;

            for (int i = 0; i < line.Length-1; i++)
            {
                if (line[i]=='>')
                {
                  power += int.Parse(line[i+1]+"");
                    continue;
                }
                if (power>0)
                {
                   line =  line.Remove(i, 1);
                    power--;
                    i--;
                }
            }
            Console.WriteLine(line);
        }

        
    }
}
