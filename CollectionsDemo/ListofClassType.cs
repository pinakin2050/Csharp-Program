using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class ListofClassType
    {
        public string Eid { get; set; }
        public string Ename { get; set; }
        public double Salary { get; set; }
        public string City { get; set; }
    }

    class ExecuteClass
    {
        static void Main()
        {
            ListofClassType obj1 = new ListofClassType()
            {
                Eid = "001",
                Ename = "Pinakin",
                Salary = 30000,
                City = "Surat"
            };

            ListofClassType obj2 = new ListofClassType()
            {
                Eid = "002",
                Ename = "Jigar",
                Salary = 30000,
                City = "Valsad"
            };

            ListofClassType obj3 = new ListofClassType()
            {
                Eid = "003",
                Ename = "Jenish",
                Salary = 30000,
                City = "Navsari"
            };

            List<ListofClassType> l = new List<ListofClassType>();
            l.Add(obj1);
            l.Add(obj2);
            l.Add(obj3);

            foreach (ListofClassType obj in l)
                Console.WriteLine(obj.Eid + "\t" + obj.Ename + "\t" + obj.Salary + "\t" + obj.City);
        }
    }
}
