using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {

            Shape a = new Circle(5);
            Shape b = new Rectrangle(5, 3);
            Console.WriteLine(a.Draw());
            Console.WriteLine(b.Draw());
        }
    }
}
