using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            var keyItems = new Dictionary<string, int>();
            keyItems.Add("shards", 0);
            keyItems.Add("fragments", 0);
            keyItems.Add("motes", 0);
            var junk = new Dictionary<string, int>();
            bool farming = true;
            while (farming)
            {

                string[] input = Console.ReadLine().Split();



                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[0 + i]);
                    string item = input[1 + i].ToLower();
                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        keyItems[item] += quantity;
                        if (keyItems[item] >= 250)
                        {
                            keyItems[item] = keyItems[item]-250;
                            if (item== "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (item == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            
                            farming = false;
                            break;
                        }

                    }
                    
                    else
                    {
                        if (!junk.ContainsKey(item))
                        {
                            junk.Add(item, 0);
                        }
                        
                        
                            junk[item] += quantity;
                        
                    }


                }
            }
            
            foreach (var item in keyItems.OrderByDescending(item=>item.Value).ThenBy(item=>item.Key))
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
            foreach (var item in junk.OrderBy(item=>item.Key))
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
    }
}
