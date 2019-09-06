using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _01._Vapor_Winter_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamePrice = new Dictionary<string, double>();
            var gameDlc = new Dictionary<string, string>();
           
            string[] input = Console.ReadLine().Split(", ");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains(':'))
                {
                    string[] splitedDlc = input[i].Split(":");
                    string game = splitedDlc[0];
                    string dlc = splitedDlc[1];
                    if (gamePrice.ContainsKey(game))
                    {
                        if (gameDlc.ContainsKey(game)==false)
                        {
                            gameDlc.Add(game, dlc);
                            gamePrice[game] += (gamePrice[game] * 0.20);
                        }
                    }

                }
                else
                {
                    string[] splitedGamePrice = input[i].Split("-");
                    string game = splitedGamePrice[0];
                    double price = double.Parse(splitedGamePrice[1]);
                    if (gamePrice.ContainsKey(game)==false)
                    {
                        gamePrice.Add(game, price);
                        
                    }
                }
            }
           
            foreach (var item in gamePrice.OrderBy(x=>x.Value))
            {
                if (gameDlc.ContainsKey(item.Key))
                {
                    Console.WriteLine($"{item.Key} - {gameDlc[item.Key]} - { gamePrice[item.Key] -= (gamePrice[item.Key] * 0.50):f2} ");
                }
            }
            foreach (var item in gamePrice.OrderByDescending(x=>x.Value))
            {
                if (gameDlc.ContainsKey(item.Key)==false)
                {
                    Console.WriteLine($"{item.Key} - {gamePrice[item.Key] -= (gamePrice[item.Key] * 0.20):f2} ");
                }
            }
        }
    }
}
