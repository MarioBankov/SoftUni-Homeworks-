using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Foods
{
    public class Meat : Food
    {
        public Meat(int quantity) 
            : base(quantity)
        {
        }
        Food a = new Meat(2);
    }
}
