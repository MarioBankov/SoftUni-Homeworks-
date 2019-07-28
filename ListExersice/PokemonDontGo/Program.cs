using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;


            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                

                if (index < 0)
                {
                    int pokemon = numbers[0];
                    sum += numbers[0];
                    numbers.RemoveAt(0);

                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= pokemon)
                        {
                            numbers[i] = numbers[i] + pokemon;
                        }
                        else
                        {
                            numbers[i] = numbers[i] - pokemon;
                        }
                    }


                }
                else if (index > numbers.Count - 1)
                {
                    int pokemon = numbers[numbers.Count-1];
                    sum += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(numbers.Count , numbers[0]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= pokemon)
                        {
                            numbers[i] = numbers[i] + pokemon;
                        }
                        else
                        {
                            numbers[i] = numbers[i] - pokemon;
                        }
                    }

                }
                else
                {
                    int pokemon = numbers[index];

                    sum += pokemon;
                    numbers.RemoveAt(index);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= pokemon)
                        {
                            numbers[i] = numbers[i] + pokemon;
                        }
                        else
                        {
                            numbers[i] = numbers[i] - pokemon;
                        }
                    }
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
