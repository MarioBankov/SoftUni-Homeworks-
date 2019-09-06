    using System;
    using System.Linq;
    using System.Numerics;

    namespace FromLeftToRight
    {
        class Program
        {
            static void Main(string[] args)
            {

                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    long[] data = Console.ReadLine().Split().Select(long.Parse).ToArray();

                    long leftNumber = data[0];
                    long rightNumber = data[1];
                    if (leftNumber > rightNumber)
                    {
                        long sum = 0;
                        leftNumber = Math.Abs(leftNumber);
                        while (leftNumber > 0)
                        {
                            sum += leftNumber % 10;
                            leftNumber /= 10;
                        }
                        Console.WriteLine(sum);
                    }

                    else
                    {
                        long sum = 0;
                        data[1] = Math.Abs(data[1]);
                        while (data[1]!= 0)
                        {
                            sum += data[1] % 10;
                            data[1] /= 10;
                        }
                        Console.WriteLine(sum);
                    }

                }

            }
        }
    }
