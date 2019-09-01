using Collection_Hierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy.Model
{
    public class MyList : IMyList
    {
        private List<string> collection;

        public MyList()
        {
            this.collection = new List<string>();
        }
        public MyList(string[] arr)
        {
            this.collection = new List<string>(arr);
        }

        public int Used => collection.Count;

        public int Add(string element)
        {
            collection.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            if (collection.Count>0)
            {
                var toRemove = collection[0];
                collection.RemoveAt(0);
                return toRemove;
            }
            else
            {
                throw new ArgumentException();
            }
           
            
        }
    }
}
