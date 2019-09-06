using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Cstack<T>:IEnumerable<T>
    {
        private List<T> list;
        public Cstack(List<T>elements)
        {
            this.list = new List<T>(elements);
        }
        public void Push(T element)
        {
            list.Add(element);
        }
        public T Pop()
        {
            if (list.Count==0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var result = list.Last();
            list.RemoveAt(list.Count - 1);
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count-1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
