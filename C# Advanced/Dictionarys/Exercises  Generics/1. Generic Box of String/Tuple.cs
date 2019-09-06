using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExersice
{
     public class Tuple<T,U>
    {
        private T element;
        private U element1;
        public Tuple(T element,U element1)
        {
            this.element = element;
            this.element1 = element1;
        }
        public override string ToString()
        {
            return $"{element} -> {element1}";
        }

    }
}
