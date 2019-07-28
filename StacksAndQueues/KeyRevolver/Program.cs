using System;
using System.Linq;
using System.Collections.Generic;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBulet = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int value = int.Parse(Console.ReadLine());
            Queue<int> quele = new Queue<int>(bullets.Reverse());
            Stack<int> Locks = new Stack<int>(locks.Reverse());
            int count = 0;


            while (quele.Count != 0 && Locks.Count != 0)
            {

                for (int i = 0; i < sizeGunBarrel; i++)
                {
                    if (quele.Count != 0 && Locks.Count != 0)
                    {
                        int bulet = quele.Dequeue();
                        count++;
                        int @lock = Locks.Pop();
                        if (bulet <= @lock)
                        {
                            Console.WriteLine("Bang!");

                        }
                        else
                        {
                            Console.WriteLine("Ping!");
                            Locks.Push(@lock);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (quele.Count > 0&&count%sizeGunBarrel==0)
                {
                    Console.WriteLine("Reloading!");
                }

            }
            if (Locks.Count > 0)
            {
                Console.WriteLine("Couldn't get through. Locks left: {0}", Locks.Count);
            }
            else
            {
                int money = value - (priceBulet * count);
                Console.WriteLine("{0} bullets left. Earned ${1}", quele.Count, money);
            }

        }
    }
}
