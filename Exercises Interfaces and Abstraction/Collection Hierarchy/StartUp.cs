using Collection_Hierarchy.Interfaces;
using Collection_Hierarchy.Model;
using System;
using System.Collections.Generic;

namespace Collection_Hierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();
            IAdd addcollection = new AddCollection();
            IAddRemove addRemoveCollection = new AddRemoveCollection();
            IMyList mylist = new MyList();
            List<int> result = new List<int>();
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();
            foreach (var item in data)
            {
                result.Add(addcollection.Add(item));
                result1.Add(addRemoveCollection.Add(item));
                result2.Add(mylist.Add(item));
            }
            Console.WriteLine(string.Join(" ",result));
            Console.WriteLine(string.Join(" ", result1));
            Console.WriteLine(string.Join(" ", result2));
            int n = int.Parse(Console.ReadLine());
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            for (int i = 0; i < n; i++)
            {
                a.Add((addRemoveCollection.Remove()));
                b.Add((mylist.Remove()));
            }
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine(string.Join(" ", b));



        }
    }
}
