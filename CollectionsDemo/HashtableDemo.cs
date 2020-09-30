using System;
using System.Collections;

namespace CollectionsDemo
{
    class HashtableDemo
    {
        static void Main()
        {
            Hashtable hs = new Hashtable();
            hs.Add("Eid",001);
            hs.Add("Ename","Pinakin Brahmin");
            hs.Add("Job","Software Tester");
            hs.Add("Salary","25000");
            hs.Add("MgrId",007);
            hs.Add("MobileNo","9532114562");
            hs.Add("Email","pinakin@gmail.com");
            hs.Add("Dname","Product QA");
            hs.Add("Did",006);
            hs.Add("Location","Surat");

            foreach(object key in hs.Keys)
                Console.WriteLine(key + ": " + hs[key]);

            //Printing only values
            //foreach(object values in hs.Values)
            //    Console.WriteLine(values);

        }
    }
}
