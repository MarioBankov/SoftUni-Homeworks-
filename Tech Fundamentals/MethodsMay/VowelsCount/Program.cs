    using System;

    namespace VowelsCount
    {
        class Program
        {
            static void Main(string[] args)
            {
                string text = Console.ReadLine();
                int vowels = VowelCounter(text);
                Console.WriteLine(vowels);
            }

            static int VowelCounter(string text)
            {
                int count = 0;
                string vowels = "aouei";
                for (int i = 0; i < text.Length; i++)
                {
                    if (vowels.Contains(text[i]))
                    {
                        count++;
                    }

                }
                return count;
            }
        }
    }
