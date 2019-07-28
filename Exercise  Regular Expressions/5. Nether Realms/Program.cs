using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
 
namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(n => n).ToList();

            Regex digetRegex = new Regex(@"([-+]?(\d+\.)?\d+)");
            Regex letersRegex = new Regex(@"[^\d+\-*/.]");


            var damage = 0.0;
            var health = 0.0;
            var name = "";

            for (int i = 0; i < input.Count; i++)
            {
                var matchDemonsDamage = digetRegex.Matches(input[i]).Cast<Match>().Select(d => double.Parse(d.Value)).Sum();
                var matchDemonsHealth = letersRegex.Matches(input[i]).Cast<Match>().Select(h => (int)char.Parse(h.Value)).Sum();

                var multiplyCount = input[i].Count(m => m == '*');
                var delenie = input[i].Count(m => m == '/');

                if (multiplyCount > 0)
                {
                    matchDemonsDamage *= Math.Pow(2, multiplyCount);
                }
                if (delenie > 0)
                {
                    matchDemonsDamage /= Math.Pow(2, delenie);
                }
                damage = matchDemonsDamage;
                health = matchDemonsHealth;
                name = input[i];

                Console.WriteLine($"{name} - {health} health, {damage:0.00} damage");
            }
        }
    }
}