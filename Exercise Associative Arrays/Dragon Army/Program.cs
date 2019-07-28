    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Dragon_Army
    {
        class Program
        {
            static void Main(string[] args)
            {                                //type             name       stats 
                var dragons = new Dictionary<string, Dictionary<string, List<int>>>();
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string[] data = Console.ReadLine().Split();
                    string type = data[0];
                    string name = data[1];
                    string dmgAsString = data[2];
                    string healthAsString = data[3];
                    string armorAsString = data[4];
                    if (dmgAsString == "null")
                    {
                        dmgAsString = "45";
                    }
                    if (healthAsString == "null")
                    {
                        healthAsString = "250";
                    }
                    if (armorAsString == "null")
                    {
                        armorAsString = "10";
                    }
                    int dmg = int.Parse(dmgAsString);
                    int health = int.Parse(healthAsString);
                    int armor = int.Parse(armorAsString);

                    if (dragons.ContainsKey(type) == false)
                    {
                        dragons.Add(type, new Dictionary<string, List<int>>());
                        dragons[type].Add(name, new List<int>());
                        dragons[type][name].Add(health);
                        dragons[type][name].Add(dmg);
                        dragons[type][name].Add(armor);

                    }
                    else if (dragons.ContainsKey(type) && dragons[type].ContainsKey(name) == false)
                    {
                        dragons[type].Add(name, new List<int>());
                        dragons[type][name].Add(health);
                        dragons[type][name].Add(dmg);
                        dragons[type][name].Add(armor);
                    }
                    else if (dragons.ContainsKey(type) && dragons[type].ContainsKey(name))
                    {
                        dragons[type][name].Clear();
                        dragons[type][name].Add(health);
                        dragons[type][name].Add(dmg);
                        dragons[type][name].Add(armor);
                    }
                }
                foreach (var kvp in dragons)
                {
                    double totalDmg = 0;
                    double totalHealth = 0;
                    double totalArmor = 0;
                    var nameStats = kvp.Value;
                    int count = 0;
                    foreach (var item in nameStats)
                    {
                        totalDmg += item.Value[1];
                        totalHealth += item.Value[0];
                        totalArmor += item.Value[2];
                        count++;
                    }
                    double avarageDmg = totalDmg / count;
                    double avarageHealth = totalHealth / count;
                    double avarageArmor = totalArmor / count;
                    Console.WriteLine($"{kvp.Key}::({avarageDmg:f2}/{avarageHealth:f2}/{avarageArmor:f2})");
                    foreach (var item in nameStats.OrderBy(x=>x.Key))
                    {
                        Console.WriteLine($"-{item.Key} -> damage: {item.Value[1]}, health: {item.Value[0]}, armor: {item.Value[2]}");
                    }
                }
            }
        }
    }
