using System;

namespace Class_Box_Data
{
   public  class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box box = null;
            try
            {
               box = new Box(length, width, height);
            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.Message);
                return;
            }
           

            Console.WriteLine("Surface Area – {0:f2}",box.SurfaceArea());
            Console.WriteLine("Lateral Surface Area – {0:f2}",box.LiteralSurfaceArea());
            Console.WriteLine("Volume – {0:f2}",box.Volume());
        }
    }
}
