using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car : ICar
    {
        public string Color { get; private set; }
        public string Model { get; private set; }
        public int Battery { get; private set; }

        public virtual string Start()
        {
            return "Engine start";
        }

        public virtual string Stop()
        {
            return "Breaaak!";
        }
    }
}
