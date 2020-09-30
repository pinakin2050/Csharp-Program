using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CollectionsDemo
{
    public class IComparerDemo
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public double Fees { get; set; }

        static void Main()
        {
            IComparerDemo s1 = new IComparerDemo() { Sid = 234, Sname = "Yudhisthir", Fees = 35000.650 };
            IComparerDemo s2 = new IComparerDemo() { Sid = 109, Sname = "Bhim", Fees = 21000.4568 };
            IComparerDemo s3 = new IComparerDemo() { Sid = 567, Sname = "Arjun", Fees = 40000.2355 };
            IComparerDemo s4 = new IComparerDemo() { Sid = 134, Sname = "Nakul", Fees = 32893.1235 };
            IComparerDemo s5 = new IComparerDemo() { Sid = 987, Sname = "Sahdev", Fees = 35000.650 };

            List<IComparerDemo> ls = new List<IComparerDemo>() { s1, s2, s3, s4, s5 };

            Console.WriteLine("List before sorting:");
            foreach (IComparerDemo obj in ls)
                Console.WriteLine("Sid: " + obj.Sid + "\tSname: " + obj.Sname + "\tFees: " + obj.Fees);

            //To sort list using IComparer we use new class and implement the interface and give implementation for Compare method.
            //Then we pass the instance of new class in the Sort method
            SortClass sortObj = new SortClass();
            ls.Sort(sortObj);

            Console.WriteLine("\nList after sorting on Fees:");
            foreach (IComparerDemo obj in ls)
                Console.WriteLine("Sid: " + obj.Sid + "\tSname: " + obj.Sname + "\tFees: " + obj.Fees);
        }
    }
        public class SortClass : IComparer<IComparerDemo>
        {
            public int Compare(IComparerDemo x, IComparerDemo y)
            {
                if (x.Fees > y.Fees)
                    return 1;
                else if (x.Fees < y.Fees)
                    return -1;
                else
                    return 0;
            }
        }
}
