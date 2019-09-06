using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparatorsExercises
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private List<T> list;
        int index = 0;
        public ListyIterator(params T[]elements)
        {
            list = new List<T>(elements);
        }

        public bool Move()
        {
            if (index<list.Count-1)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return index+1 < list.Count; 
        }
        public void Print()
        {
            if (list.Count==0||(index<0&&index>=list.Count))
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(list[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {

            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
