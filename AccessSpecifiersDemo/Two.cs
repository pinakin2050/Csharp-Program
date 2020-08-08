using System;

namespace AccessSpecifiersDemo
{
    //Consuming members from the child class of the same project
    class Two : One //Extending Class One
    {
        static void Main()
        {
            Two obj2 = new Two();
            Console.WriteLine("Consuming methods from child class of same project.");
            obj2.ProtectedMethod();
            obj2.InternalMethod();
            obj2.ProtectedInternalMethod();
            obj2.PublicMethod();
        }
    }
}
