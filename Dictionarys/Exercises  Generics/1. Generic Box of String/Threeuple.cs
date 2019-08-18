using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExersice
{
    public class Threeuple<T1,T2,T3>
    {
        public Threeuple(T1 t1,T2 t2,T3 t3)
        {
            First = t1;
            Second = t2;
            Tirth = t3;
        }
        public T1 First { get; set; }
        public T2 Second { get; set; }
        public T3 Tirth { get; set; }
        public override string ToString()
        {
            
            return $"{First} -> {Second:f1} -> {Tirth}";
        }
    }
    
}
