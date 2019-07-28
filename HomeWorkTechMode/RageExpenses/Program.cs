using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousetPrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headsetcount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetcount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;

                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }

            }
            double total = (headsetPrice * headsetcount) + (mouseCount * mousetPrice) + (keyboardCount * keyboardPrice) + (displayPrice * displayCount);
            Console.WriteLine("Rage expenses: {0:f2} lv.", total);
        }
    }
}
