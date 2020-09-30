using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class GenericListDemo
    {
        static void DisplayList(List<int> ls)
        {
            foreach (int i in ls)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        static void Main()
        {
            List<int> ls = new List<int>();
            ls.Add(10);
            ls.Add(20);
            ls.Add(40);
            ls.Add(30);
            ls.Add(50);

            Console.WriteLine("List elements:");
            DisplayList(ls);

            ls.Insert(3, 100);
            Console.WriteLine("List elements after ls.Insert(3, 100):");
            DisplayList(ls);

            ls.RemoveAt(1);
            Console.WriteLine("List elements after ls.RemoveAt(1):");
            DisplayList(ls);
        }
    }
}
