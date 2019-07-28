using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMat = new Dictionary<string, int>();
            keyMat.Add("shards", 0);
            keyMat.Add("fragments", 0);
            keyMat.Add("motes", 0);
            var junk = new Dictionary<string, int>();
            bool webObtained = false;
            while (webObtained==false)
            {
                string[] mats = Console.ReadLine().ToLower().Split();

              
                for (int i = 0; i < mats.Length; i+=2)
                {

                    string mat = mats[i+1];
                    int quantity = int.Parse(mats[i]);
                    if (mat == "shards" || mat == "fragments" || mat == "motes")
                    {
                        keyMat[mat] += quantity;
                        if (keyMat[mat] >= 250)
                        {
                            webObtained = true;
                            keyMat[mat] -= 250;
                            if (mat == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");

                            }
                            else if (mat == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");

                            }
                            else if (true)
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(mat) == false)
                        {
                            junk.Add(mat, quantity);
                        }
                        else
                        {
                            junk[mat] += quantity;
                        }
                    }
                }
            }
            foreach (var item in keyMat.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
}
