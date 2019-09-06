using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragonAvarage = new Dictionary<string, List<double>>();
            var dragons = new Dictionary<string, Dictionary<string, List<int>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split().ToList();
                string type = input[0];
                string name = input[1];
                int number;
                bool success = Int32.TryParse(input[2], out number);
                int dmg = 0;
                if (success)
                {
                     dmg = int.Parse(input[2]);
                }
                else
                {
                    dmg = 45;
                }

                int health = 0;
                bool success1 = Int32.TryParse(input[3], out number);
                if (success1)
                {
                    health = int.Parse(input[3]);
                }
                else
                {
                    health = 250;
                }
                int armor = 0;
                bool success2 = Int32.TryParse(input[4], out number);
                if (success2)
                {
                    armor = int.Parse(input[4]);
                }
                else
                {
                    armor = 10;
                }
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new Dictionary<string, List<int>>());
                    dragons[type].Add(name, new List<int>());
                    dragons[type][name].Add(dmg);
                    dragons[type][name].Add(health);
                    dragons[type][name].Add(armor);
                }
                else
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, new List<int>());
                        dragons[type][name].Add(dmg);
                        dragons[type][name].Add(health);
                        dragons[type][name].Add(armor);

                    }
                }
            }
            
            foreach (var item in dragons)
            {
                double avarageDmg = 0;
                double avarageHealth = 0;
                double avarageArmor = 0;
                int b = 0;
                foreach (var itemm in dragons[item.Key])
                {
                    List<int> parameters = itemm.Value;
                    
                    for (int i = 0; i < parameters.Count; i+=3)
                    {
                        avarageDmg += parameters[i];
                        avarageHealth += parameters[i + 1];
                        avarageArmor += parameters[i + 2];
                        b++;
                    }
                }
                avarageDmg = avarageDmg / b;
                avarageHealth = avarageHealth / b;
                avarageArmor = avarageArmor / b;
              
                if (!dragonAvarage.ContainsKey(item.Key))
                {
                    dragonAvarage.Add(item.Key, new List<double>());
                    dragonAvarage[item.Key].Add(avarageDmg);
                    dragonAvarage[item.Key].Add(avarageHealth);
                    dragonAvarage[item.Key].Add(avarageArmor);
                }
            }
            foreach (var item in dragonAvarage)
            {
                string type = item.Key;
                double dmg = item.Value[0];
                double healt = item.Value[1];
                double armor = item.Value[2];
                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})",type,dmg,healt,armor);
                foreach (var itemm in dragons[item.Key].OrderBy(x=>x.Key))
                {
                    string name = itemm.Key;
                    double dmg1 = itemm.Value[0];
                    double healt1 = itemm.Value[1];
                    double armor1 = itemm.Value[2];
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}",name,dmg1,healt1,armor1);

                }
            }
           

        }
    }
}
