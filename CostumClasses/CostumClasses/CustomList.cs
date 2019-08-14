using System;
using System.Collections.Generic;
using System.Text;

namespace CostumClasses
{
    public class CustomList
    {
        private int[] arr;
        private int defaultSize = 2;


        public CustomList()
        {
            this.arr = new int[defaultSize];
        }
        public CustomList(int size)
        {
            this.arr = new int[size];
            Count = size;
        }
        public CustomList(int[]array)
        {
            this.arr = array;
            Count = array.Length;

        }
        public int this[int index]
        {
            get
            {
                isIndexInRange(index);
                return arr[index];
            }
            
        }
        public int Count { get; private set; }

        public void Add(int element)
        {
            if (arr.Length == Count)
            {
                Grow();
            }
            arr[Count] = element;
            Count++;
        }
        public void Insert(int index, int element)
        {
            isIndexInRange(index);
            if (arr.Length == Count)
            {
                Grow();
            }
            ShiftRight(index);
            arr[index] = element;
            Count++;
        }
        
        public void AddCollection(int[] arr)
        {
            while (arr.Length + Count > this.arr.Length)
            {
                Grow();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i + Count] = arr[i];
            }
            Count += arr.Length;
        }
        public void RemoveAt(int index)
        {
            isIndexInRange(index);
            ShiftLeft(index);
            Count--;
        }
        
        public bool Contains(int index)
        {
            for (int i = 0; i < Count; i++)
            {
                if (arr[i]==index)
                {
                    return true;
                }
            }
            return false;
        }
        public List<int> ToList()
        {
            var result = new List<int>();
            for (int i = 0; i < Count; i++)
            {
                result.Add(arr[i]);
            }
            return result;
        }
        public void Foreach(Action<int>action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(arr[i]);
            }
        }
        private void isIndexInRange(int index)
        {
            if (index < 0 || index > this.arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[Count - 1] = 0;

        }
        private void ShiftRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[index] = 0;
        }

        private void Grow()
        {
            int[] tempArr = new int[arr.Length * 2];
            for (int i = 0; i < arr.Length; i++)
            {
                tempArr[i] = arr[i];
            }
            arr = tempArr;
        }
    }
}
