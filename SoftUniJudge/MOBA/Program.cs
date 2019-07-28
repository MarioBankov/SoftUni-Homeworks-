using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                List<string> tokens = Console.ReadLine()
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (tokens[0]=="Season")
                {
                    break;
                }
                if (!tokens.Contains("vs"))
                {
                    string name = tokens[0];
                    string position = tokens[1];
                    int points = int.Parse(tokens[2]);
                    if (!players.ContainsKey(name))
                    {
                        players.Add(name, new Dictionary<string, int>());
                        players[name][position] = points;
                    }
                    else
                    {
                        if (players[name].ContainsKey(position))
                        {
                            if (players[name][position]<points)
                            {
                                players[name][position] = points;
                            }
                        }
                        else
                        {
                            players[name].Add(position, points);
                        }
                    }
                }
                else
                {
                    string playerOne = tokens[0];
                    string playerTwo = tokens[2];
                    if (players.ContainsKey(playerOne)&&players.ContainsKey(playerTwo))
                    {
                        string remove = "";
                        foreach (var pos in players[playerOne])
                        {
                           
                            foreach (var pos2 in players[playerTwo])
                            {
                                if (pos.Key==pos2.Key)
                                {
                                    int playerOnePoints = players[playerOne].Values.Sum();
                                    int playerTwoPoints = players[playerTwo].Values.Sum();

                                    if (playerOnePoints > playerTwoPoints)
                                    {
                                        remove = playerTwo;  
                                    }
                                    else if (playerOnePoints < playerTwoPoints)
                                    {
                                        remove = playerOne;
                                    } 
                                }
                               
                            }
                        }
                        players.Remove(remove);
                    }

                }
            }
            var dic = new Dictionary<string, int>();

            foreach (var item in players)
            {
                dic.Add(item.Key, item.Value.Values.Sum());
                
            }
            foreach (var item in dic.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
               
                Console.WriteLine("{0}: {1} skill", item.Key, item.Value);
                foreach (var itemm in players[item.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine("- {0} <::> {1}",itemm.Key,itemm.Value);
                }
            }
        }
    }
}
