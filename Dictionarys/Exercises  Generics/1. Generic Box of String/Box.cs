using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExersice
{
    public class Box<T> where T:IComparable<T>
    {
        private List<T> list;
        public Box()
        {
            list = new List<T>();
        }
        public void Add(T element)
        {
            list.Add(element);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString();
        }
        public void Swap(int a, int b)
        {
            var temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        public int Compare(T element)
        {
            int result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(element)>0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
