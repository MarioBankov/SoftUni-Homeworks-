using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            ulong population =ulong.Parse( Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine("Town {0} has population of {1} and area {2} square km.",townName,population,area);
        }
    }
}
