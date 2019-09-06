using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
       
        public string Model { get; private set; }
        public string Color { get; private set; }

        public Seat(string model, string color)
        {
            this.Color = color;
            this.Model = model;
        }


        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
                var sb = new StringBuilder();
                sb.AppendLine($"{this.Color} {nameof(Seat)} {this.Model}");
                sb.AppendLine($"{this.Start()}");
                sb.AppendLine($"{this.Stop()}");

                return sb.ToString().TrimEnd();
        }
    }
}
