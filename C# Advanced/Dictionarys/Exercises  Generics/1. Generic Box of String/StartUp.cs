using System;
using System.Linq;

namespace GenericsExersice
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" ",4);

            string name = line[0] + " " + line[1];
            var NameAdres = new Threeuple<string, string, string>(name, line[2],line[3]);
            
            string[] line1 = Console.ReadLine().Split();
            var beer = new Threeuple<string, double, string>(line1[0], double.Parse(line1[1]), line[2]);
            
            string[] line2 = Console.ReadLine().Split();
            var bank = new Threeuple<string, decimal, string>(line2[0], decimal.Parse(line2[1]), line2[2]);
            Console.WriteLine(NameAdres);
            if (line1[2] == "drunk")
            {
                Console.WriteLine($"{beer.First} -> {beer.Second} -> {"True"}");
            }
            else
            {
                Console.WriteLine($"{beer.First} -> {beer.Second} -> {"False"}");
            }
            Console.WriteLine(bank);

        }

    }
}
