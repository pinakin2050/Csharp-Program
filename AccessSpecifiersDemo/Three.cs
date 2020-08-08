using System;

namespace AccessSpecifiersDemo
{
    //Consuming members from the non-child class of the same project

    class Three //Not extending any class
    {
        static void Main()
        {
            Console.WriteLine("Consuming methods from non child class of same project.");
            One obj3 = new One();
            obj3.InternalMethod();
            obj3.ProtectedInternalMethod();
            obj3.PublicMethod();
        }
    }
}
