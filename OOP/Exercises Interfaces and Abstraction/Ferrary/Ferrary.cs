using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrary
{
    public class Ferrary : ICar
    {
        public string Driver { get;private set; }
        public string Model => "488-Spider";
        public Ferrary(string driver)
        {
            this.Driver = driver;
        }
        public string Brake()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }
        public override string ToString()
        {
            return $"{Model}/{this.Brake()}/{this.Gas()}/{this.Driver}";
        }
    }
}
