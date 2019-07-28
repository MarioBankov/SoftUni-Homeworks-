using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (pokemons.Count!=0)
            {
                int index = int.Parse(Console.ReadLine());
               
               
               
                if (index < 0)
                {
                    sum += pokemons[0];
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);

                }
                else if(index>pokemons.Count-1)
                {
                    sum += pokemons[pokemons.Count - 1];
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons[0]);
                }
                else
                {
                    int pokemon = pokemons[index];
                    sum += pokemons[index];
                    pokemons.RemoveAt(index);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= pokemon)
                        {
                            pokemons[i] += pokemon;
                        }
                        else
                        {
                            pokemons[i] -= pokemon;
                        }
                    }
                   
                }
            }
            Console.WriteLine(sum);
        }
    }
}
