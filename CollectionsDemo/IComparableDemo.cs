using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CollectionsDemo
{
    class IComparableDemo : IComparable<IComparableDemo>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public float Marks { get; set; }

        //Implementing the method of IComparable
        public int CompareTo(IComparableDemo other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
        static void Main()
        {
            IComparableDemo obj1 = new IComparableDemo() { Sid = 101, Name = "Pinakin", Marks = 777.77f };
            IComparableDemo obj2 = new IComparableDemo() { Sid = 103, Name = "Jigar", Marks = 400.65f };
            IComparableDemo obj3 = new IComparableDemo() { Sid = 102, Name = "Jenish", Marks = 490.456f };

            List<IComparableDemo> ls = new List<IComparableDemo>() { obj1, obj2, obj3 };

            Console.WriteLine("List elements before sorting:");
            foreach (IComparableDemo obj in ls)
                Console.WriteLine("Sid: " + obj.Sid+ "\tName: " + obj.Name + "\tMarks:" + obj.Marks);

            //Directly using ls.Sort() will throw exception. 
            //To resolve this we must implement the IComparable interface and implement its method CompareTo
            //In that method we can provide logic to sort on field of our choice.
            ls.Sort();

            Console.WriteLine("\nList elements after sorting on Sid:");
            foreach (IComparableDemo obj in ls)
                Console.WriteLine("Sid: " + obj.Sid + "\tName: " + obj.Name + "\tMarks:" + obj.Marks);

            Console.WriteLine("\nList elements after sorting on Marks using the IComparer:");
            ComparerClass comparereObj = new ComparerClass();
            ls.Sort(comparereObj);

            foreach (IComparableDemo obj in ls)
                Console.WriteLine("Sid: " + obj.Sid + "\tName: " + obj.Name + "\tMarks:" + obj.Marks);

        }

        //Now suppose you are consuming class provided by someone else and you don't have access to the code. But you want to sort items 
        //based on your choice of field then you can use IComparer interface.
        //For that you have to make a new class and implement the IComparer interface and then implement the Compare method.
        class ComparerClass : IComparer<IComparableDemo>
        {
            public int Compare(IComparableDemo x, IComparableDemo y)
            {
                if (x.Marks > y.Marks)
                    return 1;
                else if (x.Marks < y.Marks)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
