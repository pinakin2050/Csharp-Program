using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class DictionaryDemo
    {
        public static void Main()
        {
            //In generics Hashtable was replaced by dictionary.
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("Eid", 001);
            dt.Add("Ename", "Pinakin Brahmin");
            dt.Add("Job", "Software Tester");
            dt.Add("Salary", "25000");
            dt.Add("MgrId", 007);
            dt.Add("MobileNo", "9532114562");
            dt.Add("Email", "pinakin@gmail.com");
            dt.Add("Dname", "Product QA");
            dt.Add("Did", 006);
            dt.Add("Location", "Surat");

            //Order of insertion is preserved in the Dictionary unlike Hashtable.
            foreach (string key in dt.Keys)
                Console.WriteLine(key + ": " + dt[key]);
        }
    }
}
