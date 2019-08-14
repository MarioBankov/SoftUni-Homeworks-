using System;
using System.Collections.Generic;
using System.Text;

namespace CostumClasses
{
   public class CustomStack
    {
        private int[] array;
        private int count;
        private int defaultSize = 4;

        public CustomStack()
        {
            array = new int[defaultSize];
        }
        public CustomStack(int size )
        {
            array = new int[size];
        }
        public int Count { get =>this.count; }

        public void Push(int element)
        {
            if (array.Length==Count)
            {
                Grow();
            }
            array[Count] = element;
            count++;
        }
        public int Peek()
        {
            return array[count - 1];
        }
        public int Pop()
        {
            int result = array[count - 1];
            count--;
            return result;
        }
        public bool Contains(int element)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i]==element)
                {
                    return true;
                }
            }
            return false;
        }
        public void Foreach(Action<int>action)
        {
            for (int i = count-1; i >= 0; i--)
            {
                action(array[i]);
            }
        }

        private void Grow()
        {
            int[] tempArray = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
    }
}
