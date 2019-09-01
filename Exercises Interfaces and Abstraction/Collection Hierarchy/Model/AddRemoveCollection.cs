using Collection_Hierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy.Model
{
    public class AddRemoveCollection : IAddRemove
    {
        private List<string> collection;

        public AddRemoveCollection()
        {
            this.collection = new List<string>();
        }
        public AddRemoveCollection(string[] arr)
        {
            this.collection = new List<string>(arr);
        }
        public int Add(string element)
        {
            collection.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            if (collection.Count>0)
            {
                var toReturn = collection[collection.Count - 1];
                collection.RemoveAt(collection.Count - 1);
                return toReturn;
            }
            else
            {
                throw new ArgumentException();
            }
          

        }
    }
}
