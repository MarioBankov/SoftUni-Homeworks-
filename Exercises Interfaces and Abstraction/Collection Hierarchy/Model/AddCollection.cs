using Collection_Hierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy.Model
{
    public class AddCollection : IAdd
    {
        private List<string> collection;
        public AddCollection()
        {
            this.collection = new List<string>();
        }
        public AddCollection(string[] arr)
        {
            this.collection = new List<string>(arr);
        }

        public int Add(string element)
        {
            collection.Add(element);
            return collection.Count - 1;
        }
    }
}
