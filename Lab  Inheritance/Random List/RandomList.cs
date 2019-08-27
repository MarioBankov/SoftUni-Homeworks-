using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class RandomList:List<string>
    {
        private Random rng = new Random();
        public string RandomString()
        {
            var lenght = this.Count;
            var index  = rng.Next(0, lenght);
            var element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}
